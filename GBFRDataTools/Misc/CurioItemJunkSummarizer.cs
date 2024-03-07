using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GBFRDataTools.Misc;

public class CurioItemJunkSummarizer
{
    private SqliteConnection _con;

    private Dictionary<uint, string> _questIdToName { get; } = [];
    private Dictionary<string, string> _itemidToName = [];

    public CurioItemJunkSummarizer(string sqliteFile)
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

    public Dictionary<string, CurioItem> CurioItems = [];

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM item_junk";
        var reader = com.ExecuteReader();

        while (reader.Read())
        {
            string key = (string)reader["Key"];
            int rateGroupId = (int)(long)reader["RateGroupId"];
            if (string.IsNullOrEmpty(key))
                continue;

            string[] spl = key.Split('_');
            if (spl.Length != 3)
                continue;

            if (!CurioItems.TryGetValue(key, out CurioItem curioItem))
            {
                curioItem = new CurioItem();
                curioItem.Tier = rateGroupId;
                CurioItems.Add(key, curioItem);
            }

            var com2 = _con.CreateCommand();
            com2.CommandText = $"SELECT * FROM item_junk_rate_group WHERE Key = {rateGroupId}";
            var reader2 = com2.ExecuteReader();
            while (reader2.Read())
            {
                var rateGroup = new RateGroup();
                curioItem.Groups.Add(rateGroup);

                string appearRateId = (string)reader2["AppearRateId"];

                var com3 = _con.CreateCommand();
                com3.CommandText = $"SELECT * FROM item_junk_appear_rate WHERE Key = '{appearRateId}'";
                var reader3 = com3.ExecuteReader();

                while (reader3.Read())
                {
                    string itemId1 = (string)reader3["ItemId"];
                    string itemId2 = (string)reader3["WeaponId"];
                    string itemId3 = (string)reader3["GemId"];
                    int weight = (int)(long)reader3["Weight"];
                    int rupMin = (int)(long)reader3["RupiesMin"];
                    int rupMax = (int)(long)reader3["RupiesMax"];
                    string questMin = (string)reader3["QuestID1"];
                    string questMax = (string)reader3["QuestID2"];

                    if (questMin != "00407101")
                        continue;

                    var reward = new Reward()
                    {
                        ItemId = !string.IsNullOrEmpty(itemId1) ? itemId1 :
                         !string.IsNullOrEmpty(itemId2) ? itemId2 :
                         !string.IsNullOrEmpty(itemId3) ? itemId3 :
                         "",
                        Weight = weight,
                        RupiesMin = rupMin,
                        RupiesMax = rupMax,
                        QuestMin = questMin,
                        QuestMax = questMax,
                    };
                    rateGroup.Rewards.Add(reward);
                }
            }
        }
    }

    public void DescribeAllCurioTiers(StreamWriter sw)
    {
        foreach (var q in CurioItems)
        {
            DescribeCurioContents(sw, q.Key);
            sw.WriteLine("----\n");
        }
    }

    public void DescribeCurioContents(StreamWriter sw, string itemId)
    {
        CurioItem tier = CurioItems[itemId];
        string questName = _itemidToName[itemId];

        sw.WriteLine($"## {questName}\n");

        for (int i = 0; i < tier.Groups.Count; i++)
        {
            RateGroup group = tier.Groups[i];
            int totalWeight = group.Rewards.Sum(e => e.Weight);

            sw.WriteLine($"### Group #{i + 1}");
            group.Rewards = group.Rewards.OrderByDescending(e => e.Weight).ToList();

            sw.WriteLine("```");
            sw.WriteLine($"Total Weight: {totalWeight}");

            for (int j = 0; j < group.Rewards.Count; j++)
            {
                Reward reward = group.Rewards[j];
                if (string.IsNullOrEmpty(reward.ItemId))
                {
                    sw.WriteLine($"  - Rupies ({reward.RupiesMin} to {reward.RupiesMax})");
                }
                else
                {
                    sw.WriteLine($"  - {_itemidToName[reward.ItemId]} ({(float)reward.Weight / totalWeight * 100:0.##}% - {reward.Weight})");
                }
            }
            sw.WriteLine("```\n");
            sw.WriteLine();
        }

        sw.WriteLine();
    }


    public class CurioItem
    {
        public int Tier { get; set; }
        public List<RateGroup> Groups { get; set; } = [];
    }

    public class RateGroup
    {
        public List<Reward> Rewards { get; set; } = [];
    }

    public class Reward
    {
        public string ItemId { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }
        public int RupiesMin { get; set; }
        public int RupiesMax { get; set; }
        public string QuestMin { get; set; }
        public string QuestMax { get; set; }

        public override string ToString()
        {
            return $"x{Count} {ItemId} ({Weight})";
        }
    }
}
