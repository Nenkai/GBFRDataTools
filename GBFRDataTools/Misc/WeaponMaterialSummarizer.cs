using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GBFRDataTools.Misc;

public class WeaponMaterialSummarizer
{
    private SqliteConnection _con;

    private Dictionary<uint, string> _questIdToName { get; } = [];
    private Dictionary<string, string> _itemidToName = [];

    public WeaponMaterialSummarizer(string sqliteFile)
    {
        _con = new SqliteConnection($"Data Source={sqliteFile}");
        _con.Open();

        using (var reader = new StreamReader("csv_data/quest_id.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                if (uint.TryParse(csv.GetField(0), out uint questId))
                    _questIdToName.Add(questId, csv.GetField(1));
            }
        }

        using (var reader = new StreamReader("csv_data/item_id.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                _itemidToName.Add(csv.GetField(0), csv.GetField(1));
            }
        }
    }

    private Dictionary<string, Weapon> Weapons = new Dictionary<string, Weapon>();

    public Dictionary<string, string> ModelToName = new Dictionary<string, string>()
    {
        { "PL0000", "Gran" },
        { "PL0100", "Djeeta"},
        { "PL0200", "Katalina"},
        { "PL0300", "Rackam"},
        { "PL0400", "Io"},
        { "PL0500", "Eugen"},
        { "PL0600", "Rosetta"},
        { "PL0700", "Ferry "},
        { "PL0800", "Lancelot"},
        { "PL0900", "Vane"},
        { "PL1000", "Percival"},
        { "PL1100", "Siegfried"},
        { "PL1200", "Charlotta"},
        { "PL1300", "Yodarha"},
        { "PL1400", "Narmaya"},
        { "PL1500", "Ghandagoza"},
        { "PL1600", "Zeta"},
        { "PL1700", "Vaseraga"},
        { "PL1800", "Cagliostro"},
        { "PL1900", "Id"},
        { "PL2000", "Id (Transformation)"},
        { "PL2100", "Sandalphon"},
        { "PL2200", "Seofon"},
        { "PL2300", "Tweyen"},
        { "NP0300", "Rolan" },
    };

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM weapon";
        var reader = com.ExecuteReader();

        while (reader.Read())
        {
            string key = (string)reader["Key"];
            if (key.Contains("PL0100"))
                continue; // Obliterate bootleg gran

            string[] spl = key.Split('_');
            if (spl[2] == "A0") // Ignore these, whatever they are
                continue;

            if (spl.Length == 4)
            {
                string weaponId = key[..key.LastIndexOf('_')];
                if (!Weapons.TryGetValue(weaponId, out Weapon weap))
                    continue;

                if (weap.AwakeningTiers is not null)
                    continue;

                string itemTierMap = (string)reader["AwakeMaterialTierMapId"];
                if (string.IsNullOrEmpty(itemTierMap))
                    continue;

                weap.AwakeningTiers = GetTierMap(itemTierMap);
            }
            else
            {
                Weapon weapon = new Weapon();

                string itemTierMap = (string)reader["UncapMaterialTierMapId"];
                weapon.UncapTiers = GetTierMap(itemTierMap);
                Weapons.Add(key, weapon);
            }
        }
    }

    public TierMap GetTierMap(string tierMapId)
    {
        var com = _con.CreateCommand();
        com.CommandText = $"SELECT * FROM item_tier_map WHERE Key = '{tierMapId}'";

        var map = new TierMap();
        var reader = com.ExecuteReader();
        while (reader.Read())
        {
            for (int i = 1; i < 15; i++)
            {
                int matId = (int)(long)reader[$"MaterialId{i}"];
                if (matId == 0)
                    continue;

                map.MaterialListPerTier[i-1] = GetItemMaterial(matId);
            }
        }

        return map;
    }

    public MaterialList GetItemMaterial(int id)
    {
        var com = _con.CreateCommand();
        com.CommandText = $"SELECT * FROM item_material_list WHERE Key = {id}";
        var reader = com.ExecuteReader();
        reader.Read();

        var materials = new MaterialList();
        materials.Cost = (int)(long)reader["CoinCost"];
        for (int i = 1; i < 22; i++)
        {
            string item = (string)reader[$"Item{i}"];
            if (string.IsNullOrEmpty(item))
                continue;

            materials.Items[i-1] = new Item()
            {
                ItemId = item,
                Count = (int)(long)reader[$"Count{i}"],
            };
        }

        return materials;
    }

    public void DescribeRows(StreamWriter sw)
    {
        string lastCharaId = "";

        foreach (var q in Weapons)
        {
            if (q.Value.UncapTiers.MaterialListPerTier.All(e => e is null) && q.Value.AwakeningTiers is null)
                continue;

            string thisCharaId = q.Key.Split('_')[1];
            if (thisCharaId != lastCharaId)
            {
                if (ModelToName.TryGetValue(thisCharaId, out string charName))
                    sw.WriteLine($"## {charName} ({thisCharaId})");
                else
                    sw.WriteLine($"## {thisCharaId}");
            }

            lastCharaId = thisCharaId;

            DescribeWeaponMaterialsRequired(sw, q.Key);
            sw.WriteLine("----\n");
        }
    }

    public void DescribeWeaponMaterialsRequired(StreamWriter sw, string key)
    {
        string weaponName = _itemidToName.ContainsKey(key) ? _itemidToName[key] : key;
        sw.WriteLine($"### {weaponName}");
        sw.WriteLine($":material-key: Key: `{key}`");

        sw.WriteLine("```");
        Weapon tiers = Weapons[key];
        sw.WriteLine("[Uncap Tiers]");
        for (int i = 0; i < tiers.UncapTiers.MaterialListPerTier.Length; i++)
        {
            MaterialList tier = tiers.UncapTiers.MaterialListPerTier[i];
            if (tier is null)
                continue;

            sw.WriteLine($"- Tier{i + 1} (Cost: {tier.Cost})");
            foreach (var item in tier.Items)
            {
                if (item is null)
                    break;

                sw.WriteLine($"x{item.Count} {_itemidToName[item.ItemId]}");
            }

            sw.WriteLine();
        }

        if (tiers.AwakeningTiers is not null)
        {
            sw.WriteLine();
            sw.WriteLine("[Awakening Levels]");
            for (int i = 0; i < tiers.AwakeningTiers.MaterialListPerTier.Length; i++)
            {
                MaterialList tier = tiers.AwakeningTiers.MaterialListPerTier[i];
                if (tier is null)
                    continue;

                sw.WriteLine($"- Tier{i + 1} (Cost: {tier.Cost})");
                foreach (var item in tier.Items)
                {
                    if (item is null)
                        break;

                    sw.WriteLine($"x{item.Count} {(_itemidToName.ContainsKey(item.ItemId) ? _itemidToName[item.ItemId] : item.ItemId)}");
                }

                sw.WriteLine();
            }
        }
        sw.WriteLine("```");
        sw.WriteLine();
    }

    public class Weapon
    {
        public TierMap UncapTiers { get; set; }
        public TierMap AwakeningTiers { get; set; }
    }

    public class TierMap
    {
        public MaterialList[] MaterialListPerTier { get; set; } = new MaterialList[15];
    }

    public class MaterialList
    {
        public int Cost { get; set; }
        public Item[] Items { get; set; } = new Item[21];
    }

    public class Item
    {
        public string ItemId { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"x{Count} {ItemId}";
        }
    }
}
