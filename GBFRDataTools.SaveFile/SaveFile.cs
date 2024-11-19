using System.Buffers.Binary;
using System.Runtime.InteropServices;

using FlatSharp;
using Syroot.BinaryData;

using GBFRDataTools.FlatBuffers;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.SaveData;

public class SaveGameFile
{
    public const long XXHASH64_SAVE_SEED = 0x2F1A43EBCD;

    public SaveDataBinary Binary1 { get; set; }
    public SaveDataBinary SlotData { get; set; }
    public ulong[] Hashes { get; set; }

    public record HashSectionInfo(int StartOffset, int SubSize);
    public static List<HashSectionInfo> HashSectionInfos = new List<HashSectionInfo>()
    {
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
    };

    public static SaveGameFile FromFile(string fileName)
    {
        var saveFile = new SaveGameFile();

        using var fs = File.OpenRead(fileName);
        using var bs = new BinaryStream(fs);

        int mainVersion = bs.ReadInt32();
        ulong steamId = bs.ReadUInt64();
        bs.ReadInt32();
        int subVersion = bs.ReadInt32();
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

        uint hashesOffset = BinaryPrimitives.ReadUInt32LittleEndian(slotDataBuffer.AsSpan(slotDataBuffer.Length - 0x14));
        Span<byte> hashesData = slotDataBuffer.AsSpan((int)hashesOffset);
        saveFile.Hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count))
                             .ToArray();

        if (!saveFile.CheckCurrentHash(slotDataBuffer))
            saveFile.FixCurrentHash(slotDataBuffer);

        return saveFile;
    }

    private uint GetHashesOffset(Span<byte> slotDataBuffer)
    {
        // This is how it's read, looking backwards
        return BinaryPrimitives.ReadUInt32LittleEndian(slotDataBuffer.Slice(slotDataBuffer.Length - 0x14));
    }

    private bool CheckCurrentHash(Span<byte> slotDataBuffer)
    {
        uint hashesOffset = GetHashesOffset(slotDataBuffer);
        Span<byte> hashesData = slotDataBuffer[(int)hashesOffset..];
        Span<ulong> hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count));

        UIntSaveDataUnit hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)UnitType.SAVEDATA_HASHSEED);
        if (hashSeed is null)
            return false;

        int idx = (int)(hashSeed.ValueData[0] % HashSectionInfos.Count);
        return CheckHashIndex(slotDataBuffer, idx);
    }

    private bool CheckHashIndex(Span<byte> slotDataBuffer, int idx)
    {
        uint hashesOffset = GetHashesOffset(slotDataBuffer); 
        HashSectionInfo look = HashSectionInfos[idx];

        Span<byte> section = slotDataBuffer.Slice(look.StartOffset, (int)hashesOffset - (look.StartOffset + look.SubSize));
        ulong hash = XXHash64.Hash(section, XXHASH64_SAVE_SEED);

        if (hash == Hashes[idx])
            return true;

        return false;
    }

    private void CalculateHashIndex(Span<byte> slotDataBuffer, int idx)
    {
        uint hashesOffset = GetHashesOffset(slotDataBuffer);
        HashSectionInfo look = HashSectionInfos[idx];

        Span<byte> section = slotDataBuffer.Slice(look.StartOffset, (int)hashesOffset - (look.StartOffset + look.SubSize));
        ulong hash = XXHash64.Hash(section, XXHASH64_SAVE_SEED);

        Hashes[idx] = hash;
    }

    private void FixCurrentHash(Span<byte> slotDataBuffer)
    {
        uint hashesOffset = GetHashesOffset(slotDataBuffer);
        Span<byte> hashesData = slotDataBuffer.Slice((int)hashesOffset);
        Span<ulong> hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count));

        UIntSaveDataUnit hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)UnitType.SAVEDATA_HASHSEED);
        hashSeed ??= new UIntSaveDataUnit()
        {
            IDType = 1003,
            ValueData = new[] { (uint)Random.Shared.Next() }
        };

        int idx = (int)(hashSeed.ValueData[0] % HashSectionInfos.Count);
        CalculateHashIndex(slotDataBuffer, idx);
    }

    public object GetSlotUnitByType(UnitType type)
    {
        if (SlotData.BoolTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.BoolTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ByteTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ByteTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UByteTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UByteTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ShortTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ShortTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UShortTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UShortTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.IntTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.IntTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.UIntTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.LongTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.LongTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.ULongTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.ULongTable.FirstOrDefault(e => e.IDType == (uint)type);

        if (SlotData.FloatTable?.Any(e => e.IDType == (uint)type) == true)
            return SlotData.FloatTable.FirstOrDefault(e => e.IDType == (uint)type);

        return null;
    }
}

public enum UnitType
{
    /// <summary>
    /// Random value/seed. This is generated at first.
    /// </summary>
    SAVEDATA_HASHSEED = 1003,

    ///////////////////
    // 512 entries
    ///////////////////
    /// <summary>
    /// UInt. Quest ids.
    /// </summary>
    QUESTSYSTEM_QUEST_IDS = 2570,

    /// <summary>
    /// UInt. Quest ids.
    /// </summary>
    QUESTSYSTEM_QUEST_COMPLETECOUNT = 2571,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK2 = 2572,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK3 = 2573,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_FLAGS = 2574,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK5 = 2575,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK6 = 2576,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK7 = 2577,


    /// <summary>
    /// UInt/Hash
    /// </summary>
    WEAPONMANAGER_WEAPON_ID = 2803,
}
