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

namespace GBFRDataTools.SaveFile;

public class SaveGameFile
{
    public const long XXHASH64_SAVE_SEED = 0x2F1A43EBCD;

    public SaveDataBinary Binary1 { get; set; }
    public SaveDataBinary SlotData { get; set; }
    public ulong[] Hashes { get; set; }

    public record HashSectionInfo(int StartOffset, int SubSize);
    public static List<HashSectionInfo> HashSectionInfos =
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

        ArgumentNullException.ThrowIfNull(SlotData.UIntTable, nameof(SlotData.UIntTable));

        UIntSaveDataUnit? hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)UnitType.SAVEDATA_HASHSEED);
        if (hashSeed is null)
            return false;

        int idx = (int)(hashSeed.ValueData![0] % HashSectionInfos.Count);
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
        Span<byte> hashesData = slotDataBuffer[(int)hashesOffset..];
        Span<ulong> hashes = MemoryMarshal.Cast<byte, ulong>(hashesData.Slice(0, sizeof(ulong) * HashSectionInfos.Count));

        ArgumentNullException.ThrowIfNull(SlotData.UIntTable, nameof(SlotData.UIntTable));

        UIntSaveDataUnit? hashSeed = SlotData.UIntTable.FirstOrDefault(e => e.IDType == (uint)UnitType.SAVEDATA_HASHSEED);
        hashSeed ??= new UIntSaveDataUnit()
        {
            IDType = (uint)UnitType.SAVEDATA_HASHSEED,
            ValueData = [(uint)Random.Shared.Next()]
        };

        int idx = (int)(hashSeed.ValueData![0] % HashSectionInfos.Count);
        CalculateHashIndex(slotDataBuffer, idx);
    }

    public object? GetSlotUnitByType(UnitType type)
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
}

public enum UnitType
{
    // 803/811 - ? (changes on trivial save)
    // 812 - Game timer (hours played)
    // 834 - Player Name
    // 1106 - Commendations?
    // 1108 - Online Status
    // 1206 - Health?
    // 1402 - Weapon Slot ID
    // 2201 - Current Party (character ids)

    // 2509 - Current Position

    // 4302 - Game Options - Gameplay - Invert Vertical Look
    // 4303 - Game Options - Gameplay - Invert Horizontal Look
    // 4305 - Game Options - Gameplay - Camera Repositioning (Bool)
    // 4307 - Game Options - Gameplay - Battle Camera Repositioning (Bool)
    // 4310 - Game Options - Gameplay - Auto Dash (Bool)
    // 4312 - Game Options - Gameplay - Auto Target Switching (Bool)
    // 4313 - Game Options - Gameplay - Vibration (Bool)
    // 4315 - Game Options - Gameplay - Difficulty Type
    // 4316 - Game Options - Gameplay - Assist Mode
    // 4317 - Game Options - Gameplay - Auto Save (Bool)
    // 4318 - Game Options - Gameplay - Autoplay Dialogue (Bool)
    // 4319 - Game Options - Gameplay - Screen Shake (Bool)
    // 4321 - Game Options - Control Scheme - Guard/Lock On Buttons (Bool)
    // 4322 - Game Options - Gameplay - Communication Wheel Selection Stick
    // 4324 - Game Options - Gameplay - Autoplay Fate Episode (Bool)
    // 4326 - Game Options - Gameplay - Override Hold SBA for Chain Bursting (Bool)
    // 4327 - Game Options - Gameplay - Skybound Art Target Priority
    // 4328 - Game Options - Gameplay - Skybound Art Activation
    // 4329 - Game Options - Gameplay - Camera Terrain Adjustment
    // 4330 - Game Options - Gameplay - Quest Cutscene Auto-Skip (Bool)
    // 4331 - Game Options - Gameplay - Loading Screen Skip (Bool)
    // 4332 - Game Options - Gameplay - Navyrngate (Bool)
    // 4333 - Game Options - Gameplay - Camera Sensitivity (Vertical)
    // 4334 - Game Options - Gameplay - Camera Sensitivity (Horizontal)
    // 4335 - Game Options - Gameplay - Aim Sensitivity (Vertical)
    // 4336 - Game Options - Gameplay - Aim Sensitivity (Horizontal)
    // 4337 - Game Options - Gameplay - Camera Smoothing (Bool)
    // 4338 - Game Options - Gameplay - Battle Camera Correction (Bool)
    // 4339 - Game Options - Gameplay - Enable Map (Bool)
    // 4340 - Game Options - Gameplay - Auto Close Map (Bool)

    // 4412 - Game Options - Network Settings - Profile Visibility
    // 4413 - Co-Op Settings - Edit Profile - Player Name
    // 4420 - Control Scheme - Scheme Type
    // 4421 - Game Options - Control Scheme - Skill/Dodge Buttons (Bool)

    // 4501 - Co-Op Settings - Player List - Followed Player Steam IDs
    // 4601 - Co-Op Settings - Edit Profile - Favorite Character
    // 4603 - Co-Op Settings - Edit Profile - Badge
    // 4604 - Co-Op Settings - Edit Profile - About Me
    // 4605 - Co-Op Settings - Edit Profile - Availability
    // 4606 - Co-Op Settings - Edit Profile - Availability (again?)

    // 4703 - Player Page - Commendations
    // 4804 - Most used characters for questing
    // 4901 - Quests cleared

    // 6201 - Communication - Emotes - Ids (for reordering)
    // 6301 - Communication - Stickers - Ids (for reordering)
    // 6401 - Communication - Quick Chat - ?
    // 6402 - Communication - Quick Chat - Emote
    // 8908 - Online Status Updates? Incremented when changing online status
    // 8909 - Online Status Updates 2? Incremented when changing online status
    // 8916 - Game Options - Keyboard - Battle Controls (Byte Array, Key codes)
    // 8918 - Game Options - Keyboard - Town Controls (Byte Array, Key codes)
    // 8934 - Game Options - Keyboard - Photo Mode Controls (Byte Array, Key codes)

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
