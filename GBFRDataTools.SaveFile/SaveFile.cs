using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

using FlatSharp;
using Syroot.BinaryData;

using GBFRDataTools.FlatBuffers;
using GBFRDataTools.Hashing;
using System.Diagnostics;
using Syroot.BinaryData.Memory;

namespace GBFRDataTools.SaveFile;

public class SaveGameFile
{
    public const long XXHASH64_SAVE_SEED = 0x2F1A43EBCD;
    public const int HEADER_SIZE = 0x34;

    public const int SYSTEMDATA_SLOT_MIN_SIZE = 0x1400;
    public const int SAVEDATA_SLOT_MIN_SIZE = 0x157D000;

    public const int FILE_SIZE = 0x1600000;

    public uint MainVersion { get; set; }
    public ulong SteamId { get; set; }
    public uint SubVersion { get; set; }

    public SaveDataBinary Binary1 { get; set; }
    public SaveDataBinary SlotData { get; set; }
    public ulong[] Hashes { get; set; }

    public record HashSectionInfo(int StartOffset, int SubSize);
    public readonly static List<HashSectionInfo> HashSectionInfos =
    [
        new(0x58, 0x80),
        new(0x30, 0xA0),
        new(0x28, 0x30),
        new(0x38, 0xC0),
        new(0x40, 0xB0),
        new(0x68, 0x50),
        new(0x48, 0x60),
        new(0x70, 0x90),
        new(0x50, 0x40),
        new(0x60, 0x70),
    ];

    public static SaveGameFile FromFile(string fileName)
    {
        var saveFile = new SaveGameFile();

        using var fs = File.OpenRead(fileName);
        using var bs = new BinaryStream(fs);

        saveFile.MainVersion = bs.ReadUInt32();
        saveFile.SteamId = bs.ReadUInt64();
        bs.ReadInt32();
        saveFile.SubVersion = bs.ReadUInt32();
        long offset1 = bs.ReadInt64();
        long slotDataOffset = bs.ReadInt64();
        long size1 = bs.ReadInt64();
        long slotDataSize = bs.ReadInt64();

        bs.Position = offset1;
        byte[] blob1 = bs.ReadBytes((int)size1);
        saveFile.Binary1 = SaveDataBinary.Serializer.Parse(blob1);

        bs.Position = slotDataOffset;
        byte[] slotDataBuffer = bs.ReadBytes((int)slotDataSize);
        saveFile.SlotData = SaveDataBinary.Serializer.Parse(slotDataBuffer);

        ulong hashesOffset = BinaryPrimitives.ReadUInt64LittleEndian(slotDataBuffer.AsSpan(slotDataBuffer.Length - 0x14));
        Span<byte> hashesData = slotDataBuffer.AsSpan((int)hashesOffset);
        saveFile.Hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count))
                             .ToArray();

        if (!saveFile.CheckCurrentHash(slotDataBuffer))
            saveFile.FixCurrentHash(slotDataBuffer);

        return saveFile;
    }

    public void Save(string path)
    {
        using var fs = File.Create(path);
        Save(fs);
    }

    public void Save(Stream stream)
    {
        BinaryStream bs = new BinaryStream(stream);

        // Write part 1 first
        long binary1Offset;
        int binary1Size;
        {
            bs.Position = HEADER_SIZE;
            binary1Offset = bs.Position;

            byte[] binary1Buffer = new byte[SaveDataBinary.Serializer.GetMaxSize(Binary1)];
            binary1Size = SaveDataBinary.Serializer.Write(binary1Buffer, Binary1);
            Debug.Assert(binary1Size <= SYSTEMDATA_SLOT_MIN_SIZE);
            bs.Write(binary1Buffer);
        }

        // Write slot data
        long slotDataOffset;
        int slotDataTotalSize;
        {
            bs.Position = SYSTEMDATA_SLOT_MIN_SIZE + HEADER_SIZE;

            slotDataOffset = bs.Position;
            byte[] slotDataFlatBuffer = new byte[SaveDataBinary.Serializer.GetMaxSize(SlotData)];
            int slotDataFlatSize = SaveDataBinary.Serializer.Write(slotDataFlatBuffer, SlotData);

            uint hashesOffset = (uint)slotDataFlatSize;
            int hashesBytesSize = sizeof(ulong) * HashSectionInfos.Count;
            slotDataTotalSize = slotDataFlatSize + hashesBytesSize + 0x14;
            Debug.Assert(slotDataTotalSize <= SAVEDATA_SLOT_MIN_SIZE);
            RecalculateAllHashes(slotDataFlatBuffer, hashesOffset);

            byte[] slotDataFullBuffer = new byte[slotDataTotalSize]; // With hashes

            // Write flatbuffer & do footer with hashes
            Syroot.BinaryData.Memory.SpanWriter sw = new(slotDataFullBuffer);
            sw.WriteBytes(slotDataFlatBuffer.AsSpan(0, slotDataTotalSize));

            sw.Position = (int)hashesOffset;

            for (int i = 0; i < Hashes.Length; i++)
                sw.WriteUInt64(Hashes[i]);
            sw.WriteUInt64(hashesOffset);
            sw.WriteUInt64((ulong)Hashes.Length * sizeof(ulong)); // Always 0x50
            sw.WriteUInt32(1);

            bs.Write(slotDataFullBuffer);
        }

        bs.Position = 0;
        bs.WriteUInt32(MainVersion);
        bs.WriteUInt64(SteamId);
        bs.WriteUInt32(0);
        bs.WriteUInt32(SubVersion);
        bs.WriteInt64(binary1Offset);
        bs.WriteInt64(slotDataOffset);
        bs.WriteInt64(binary1Size);
        bs.WriteInt64(slotDataTotalSize);

        stream.SetLength(FILE_SIZE);
    }

    private ulong GetHashesOffset(Span<byte> slotDataBuffer)
    {
        // This is how it's read, looking backwards
        var footer = slotDataBuffer.Slice(slotDataBuffer.Length - 0x14);
        return BinaryPrimitives.ReadUInt64LittleEndian(footer[0..]);
    }

    private bool CheckCurrentHash(Span<byte> slotDataBuffer)
    {
        ulong hashesOffset = GetHashesOffset(slotDataBuffer);
        Span<byte> hashesData = slotDataBuffer[(int)hashesOffset..];
        Span<ulong> hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count));

        ArgumentNullException.ThrowIfNull(SlotData.UIntTable, nameof(SlotData.UIntTable));

        UIntSaveDataUnit? hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)SaveIDType.SAVEDATA_HASHSEED);
        if (hashSeed is null)
            return false;

        int idx = (int)(hashSeed.ValueData![0] % HashSectionInfos.Count);
        return CheckHashIndex(slotDataBuffer, idx);
    }

    private bool CheckHashIndex(Span<byte> slotDataBuffer, int idx)
    {
        ulong hashesOffset = GetHashesOffset(slotDataBuffer); 
        HashSectionInfo look = HashSectionInfos[idx];

        Span<byte> section = slotDataBuffer.Slice(look.StartOffset, (int)hashesOffset - (look.StartOffset + look.SubSize));
        ulong hash = XXHash64.Hash(section, XXHASH64_SAVE_SEED);

        if (hash == Hashes[idx])
            return true;

        return false;
    }

    private void CalculateHashIndex(Span<byte> slotDataBuffer, int idx)
    {
        ulong hashesOffset = GetHashesOffset(slotDataBuffer);
        HashSectionInfo look = HashSectionInfos[idx];

        Span<byte> section = slotDataBuffer.Slice(look.StartOffset, (int)hashesOffset - (look.StartOffset + look.SubSize));
        Hashes[idx] = XXHash64.Hash(section, XXHASH64_SAVE_SEED);
    }

    private void RecalculateAllHashes(Span<byte> slotDataBuffer, ulong hashesOffset)
    {
        for (int idx = 0; idx < HashSectionInfos.Count; idx++)
        {
            HashSectionInfo look = HashSectionInfos[idx];
            Span<byte> section = slotDataBuffer.Slice(look.StartOffset, (int)hashesOffset - (look.StartOffset + look.SubSize));
            Hashes[idx] = XXHash64.Hash(section, XXHASH64_SAVE_SEED);
        }
    }

    private void FixCurrentHash(Span<byte> slotDataBuffer)
    {
        ulong hashesOffset = GetHashesOffset(slotDataBuffer);
        Span<byte> hashesData = slotDataBuffer[(int)hashesOffset..];
        Span<ulong> hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count));

        ArgumentNullException.ThrowIfNull(SlotData.UIntTable, nameof(SlotData.UIntTable));

        UIntSaveDataUnit? hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)SaveIDType.SAVEDATA_HASHSEED);
        hashSeed ??= new UIntSaveDataUnit()
        {
            IDType = (uint)SaveIDType.SAVEDATA_HASHSEED,
            ValueData = [(uint)Random.Shared.Next()]
        };

        int idx = (int)(hashSeed.ValueData![0] % HashSectionInfos.Count);
        CalculateHashIndex(slotDataBuffer, idx);
    }

    public object? GetSlotUnitByType(SaveIDType type)
    {
        if (SlotData.IntTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.IntTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UIntTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.BoolTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.BoolTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.FloatTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.FloatTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ByteTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ByteTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UByteTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UByteTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ShortTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ShortTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UShortTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UShortTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.LongTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.LongTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ULongTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ULongTable.FirstOrDefault(e => e.IDType == (uint)type);

        return null;
    }

    public void SetSlotUnitValue<T>(SaveIDType idType, uint unitId, T[] value) where T : unmanaged
    {
        switch (value)
        {
            case bool[] b:
                SetOrCreate(SlotData.BoolTable ??= [], idType, unitId, b);
                return;

            case sbyte[] sb:
                SetOrCreate(SlotData.ByteTable ??= [], idType, unitId, sb);
                return;

            case byte[] ub:
                SetOrCreate(SlotData.UByteTable ??= [], idType, unitId, ub);
                return;

            case short[] s:
                SetOrCreate(SlotData.ShortTable ??= [], idType, unitId, s);
                return;

            case ushort[] us:
                SetOrCreate(SlotData.UShortTable ??= [], idType, unitId, us);
                return;

            case int[] i:
                SetOrCreate(SlotData.IntTable ??= [], idType, unitId, i);
                return;

            case uint[] ui:
                SetOrCreate(SlotData.UIntTable ??= [], idType, unitId, ui);
                return;

            case long[] l:
                SetOrCreate(SlotData.LongTable ??= [], idType, unitId, l);
                return;

            case ulong[] ul:
                SetOrCreate(SlotData.ULongTable ??= [], idType, unitId, ul);
                return;

            case float[] f:
                SetOrCreate(SlotData.FloatTable ??= [], idType, unitId, f);
                return;

            default:
                throw new NotSupportedException($"Unsupported save value type: {typeof(T)}");
        }
    }

    public void SetSlotUnitValue<T>(SaveIDType idType, uint unitId, T value) where T : unmanaged
    {
        switch (value)
        {
            case bool b:
                SetOrCreate(SlotData.BoolTable ??= [], idType, unitId, [b]);
                return;

            case sbyte sb:
                SetOrCreate(SlotData.ByteTable ??= [], idType, unitId, [sb]);
                return;

            case byte ub:
                SetOrCreate(SlotData.UByteTable ??= [], idType, unitId, [ub]);
                return;

            case short s:
                SetOrCreate(SlotData.ShortTable ??= [], idType, unitId, [s]);
                return;

            case ushort us:
                SetOrCreate(SlotData.UShortTable ??= [], idType, unitId, [us]);
                return;

            case int i:
                SetOrCreate(SlotData.IntTable ??= [], idType, unitId, [i]);
                return;

            case uint ui:
                SetOrCreate(SlotData.UIntTable ??= [], idType, unitId, [ui]);
                return;

            case long l:
                SetOrCreate(SlotData.LongTable ??= [], idType, unitId, [l]);
                return;

            case ulong ul:
                SetOrCreate(SlotData.ULongTable ??= [], idType, unitId, [ul]);
                return;

            case float f:
                SetOrCreate(SlotData.FloatTable ??= [], idType, unitId, [f]);
                return;

            default:
                throw new NotSupportedException($"Unsupported save value type: {typeof(T)}");
        }
    }

    /// <summary>
    /// Finds an existing unit matching IDType+UnitID in the given table and overwrites
    /// its ValueData, or appends a brand new unit if none exists yet.
    /// </summary>
    private static void SetOrCreate<TUnit, TValue>(IList<TUnit> table, SaveIDType idType, uint unitId, TValue[] valueData)
        where TUnit : class, new()
    {
        table ??= [];

        dynamic? existing = table.FirstOrDefault(e =>
            (uint)((dynamic)e).IDType == (uint)idType &&
            (uint)((dynamic)e).UnitID == unitId);

        if (existing is not null)
        {
            existing.ValueData = valueData;
            return;
        }

        dynamic newUnit = new TUnit();
        newUnit.IDType = (uint)idType;
        newUnit.UnitID = unitId;
        newUnit.ValueData = valueData;

        table.Add((TUnit)newUnit);
    }
}
