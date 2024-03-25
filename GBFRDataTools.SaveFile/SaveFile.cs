using System.Buffers.Binary;
using System.Runtime.InteropServices;

using FlatSharp;
using Syroot.BinaryData;

using GBFRDataTools.FlatBuffers;
using GBFRDataTools.Hashing;
using System.Collections.Generic;

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

    static Dictionary<uint, string> hashes = new Dictionary<uint, string>();
    static SaveGameFile()
    {
        using var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ids.txt"));
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            string[] spl = line.Split('|');
            if (spl.Length == 3)
            {
                if (spl[0].Length != 8)
                    continue;

                uint hash = uint.Parse(spl[0], System.Globalization.NumberStyles.HexNumber);
                hashes.TryAdd(hash, spl[2]);
            }
        }
    }
    public void PrintType(uint typeId)
    {
        string type = FindType(typeId);
        switch (type)
        {
            case "uint":
                foreach (var i in SlotData.UIntTable.Where(e => e.IDType == typeId))
                {
                    if (hashes.ContainsKey(i.ValueData[0]))
                        Console.WriteLine($"UInt: {i.IDType} - {i.UnitID} - {string.Join("", i.ValueData.Select(e => hashes[e]))} ({i.ValueData[0]:X8})");
                    else
                        Console.WriteLine($"UInt: {i.IDType} - {i.UnitID} - {string.Join("", i.ValueData.Select(e => e))} ({i.ValueData[0]:X8})");
                }
                break;

            case "int":
                foreach (var i in SlotData.IntTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Int: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "short":
                foreach (var i in SlotData.ShortTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Short: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "ushort":
                foreach (var i in SlotData.UShortTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"UShort: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "byte":
                foreach (var i in SlotData.ByteTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Byte: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => $"{(char)e}"))}");
                break;

            case "ubyte":
                foreach (var i in SlotData.UByteTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"UByte: {i.IDType} - {i.UnitID} - {i.ValueData.Value.Span[0]}");
                break;

            case "float":
                foreach (var i in SlotData.FloatTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Float: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "long":
                foreach (var i in SlotData.LongTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Long: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "ulong":
                foreach (var i in SlotData.ULongTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"ULong: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;

            case "bool":
                foreach (var i in SlotData.BoolTable.Where(e => e.IDType == typeId))
                    Console.WriteLine($"Bool: {i.IDType} - {i.UnitID} - {string.Join(",", i.ValueData.Select(e => e))}");
                break;
        }
    }
    public string FindType(uint typeId)
    {
        if (SlotData.UIntTable.Any(e => e.IDType == typeId))
            return "uint";
        else if (SlotData.IntTable.Any(e => e.IDType == typeId))
            return "int";
        else if (SlotData.ShortTable?.Any(e => e.IDType == typeId) == true)
            return "short";
        else if (SlotData.UShortTable.Any(e => e.IDType == typeId))
            return "ushort";
        else if (SlotData.ByteTable.Any(e => e.IDType == typeId))
            return "byte";
        else if (SlotData.UByteTable.Any(e => e.IDType == typeId))
            return "ubyte";
        else if (SlotData.FloatTable.Any(e => e.IDType == typeId))
            return "float";
        else if (SlotData.LongTable.Any(e => e.IDType == typeId))
            return "long";
        else if (SlotData.ULongTable.Any(e => e.IDType == typeId))
            return "ulong";
        else if (SlotData.BoolTable.Any(e => e.IDType == typeId))
            return "bool";
        else
            return "not found";
    }
}

public enum UnitType
{
    /// <summary>
    /// Type: <see cref="ushort"/>
    /// </summary>
    SAVEDATA_1001 = 1001,

    /// <summary>
    /// Type: <see cref="ushort"/>
    /// </summary>
    SAVEDATA_1002 = 1002,

    /// <summary>
    /// Type: <see cref="uint"/> - Random value/seed. This is generated at first.
    /// </summary>
    SAVEDATA_HASHSEED = 1003,

    /// <summary>
    /// Type: <see cref="ushort"/> - Unknown
    /// </summary>
    USERDATA_1101 = 1101,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    USERDATA_1102 = 1102,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    USERDATA_1103 = 1103,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_RUPIES = 1104,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1105 = 1105,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1106 = 1106,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    USERDATA_1107 = 1107,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    USERDATA_1108 = 1108,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1109 = 1109,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1110 = 1110,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1111 = 1111,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_MASTERY_POINTS = 1112,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    USERDATA_1113 = 1113,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    USERDATA_1151 = 1151,

    /// <summary>
    /// Type: <see cref="int"/> - Current location (convert to hex). Direct "st" file
    /// </summary>
    CURRENT_LOCATION_STAGE_ID = 1201,

    /// <summary>
    /// Type: <see cref="byte"/>
    /// </summary>
    CURRENT_LOCATION_1202 = 1202,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    CURRENT_LOCATION_1203 = 1203,

    /// <summary>
    /// Type: <see cref="float[4]"/>
    /// </summary>
    CURRENT_LOCATION_1204 = 1204,

    /// <summary>
    /// Type: <see cref="float[4]"/>
    /// </summary>
    CURRENT_LOCATION_1205 = 1205,

    /// <summary>
    /// Type: <see cref="int[4]"/>
    /// </summary>
    CURRENT_LOCATION_1206 = 1206,

    /// <summary>
    /// Type: <see cref="int[4]"/>
    /// </summary>
    CURRENT_LOCATION_1207 = 1207,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item ID Hash i.e ITEM_01_0000 (DB1D4F35)
    /// </summary>
    ITEMDATA_ITEM_ID = 1801,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMDATA_ITEM_COUNT = 1802,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_ITEM_FLAGS = 1803,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1804 = 1804,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1805 = 1805,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1806 = 1806,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMDATA_1807 = 1807,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item/Gem IDs i.e GEEN_146_04 (DA9136A1)
    /// </summary>
    ITEMJUNK_CURIO_REWARD_ITEMID = 1901,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1902 = 1902,

    /// <summary>
    /// Type: <see cref="uint"/> - Seed maybe?
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1903 = 1903,

    /// <summary>
    /// Type: <see cref="int"/> - Level maybe?
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1904 = 1904,

    /// <summary>
    /// Type: <see cref="uint"/> - Starts from 1000
    /// </summary>
    ITEMJUNK_SEEDCOUNTER = 2001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Curio Item IDs i.e ITEM_19_0001 (F42D8C01)
    /// </summary>
    ITEMJUNK_CURIO_IDS = 2002,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMJUNK_CURIO_ITEM_SEEDS = 2003,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMJUNK_2004 = 2004,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_MAX_SLOT_ID = 2101,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item IDs i.e ITEM_19_0001 (F42D8C01)
    /// </summary>
    ITEM_UNK_ITEM_ID = 2102,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_SLOT_IDS = 2103,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    ITEM_UNK_2104 = 2104,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_FLAGS = 2105,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_MAX_SLOT_ID = 2701,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_SLOT_IDS = 2702,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Gem ID Hash i.e GEEN_140_00 (1C4D37E4)
    /// </summary>
    GEMDATA_GEM_ID = 2703,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    GEMDATA_SKILL_1_LEVEL = 2704,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Chara ID Hash i.e PL0500 (DD7A151E)
    /// </summary>
    GEMDATA_WORN_BY = 2706,

    /// <summary>
    /// Type: <see cref="uint"/> - Flags. 1 = Locked, 2 = Unknown
    /// </summary>
    GEMDATA_FLAGS = 2707,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_2708 = 2708,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Weapon ID Hash.
    /// </summary>
    WEAPONDATA_WEAPON_ID = 2803,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Weapon XP.
    /// </summary>
    WEAPONDATA_WEAPON_XP = 2804,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2805 = 2805,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2806 = 2806,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2807 = 2807,

    /// <summary>
    /// Type: <see cref="uint"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2814 = 2814,

    /// <summary>
    /// Type: <see cref="uint"/> Flags - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2815 = 2815,

    /// <summary>
    /// Type: <see cref="uint"/> Flags
    /// </summary>
    WEAPONDATA_WEAPON_STONE_ITEM_ID = 2816,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Ability ID Hash.
    /// </summary>
    ABILITYDATA_ABILITY_ID = 3903,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ABILITYDATA_ABILITY_FLAGS = 3904,

    /// 10600 - Self
    /// 10700+ - Following
    /// 10800+ - Following again?
    /// 10900-10949 = Recent Player
    /// 11000 - Self again?

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Chara ID Hash. 
    /// </summary>
    ONLINEPLAYERLIST_CHARA_ID = 4601,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ONLINEPLAYERLIST_4602 = 4602,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ONLINEPLAYERLIST_4603 = 4603,

    /// <summary>
    /// Type: <see cref="byte"/> (string array)
    /// </summary>
    ONLINEPLAYERLIST_ABOUTME = 4604,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ONLINEPLAYERLIST_AVAILABILITY_START = 4605,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ONLINEPLAYERLIST_AVAILABILITY_END = 4606,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Island ID Hash i.e ISLAND_1ST (9C9B9723)
    /// </summary>
    ISLANDDATA_ISLAND_ID = 6101,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    ISLANDDATA_6102 = 6102,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    UNK_6801 = 6801,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    GACHADATA_7001 = 7001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to gacha table
    /// </summary>
    GACHADATA_GACHA_ID = 7002,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    GACHADATA_7003 = 7003,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to menu_unlock table
    /// </summary>
    UNLOCKDATA_UNLOCK_ID = 7101,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    UNLOCKDATA_IS_UNLOCKED = 7102,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to menu_unlock table
    /// </summary>
    UNLOCKDATA_7103 = 7103,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Gem ID Hash i.e GEEN_140_00 (1C4D37E4)
    /// </summary>
    ACQUIREDGEMS_GEM_ID = 8001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - 1 = acquired?
    /// </summary>
    ACQUIREDGEMS_ACQUIRED_FLAG = 8002,
}
