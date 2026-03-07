using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GBFRDataTools.Misc;

public class EnemyBreakPartRewardSummarizer
{
    private SqliteConnection _con;

    private Dictionary<string, string> _itemidToName = [];

    public EnemyBreakPartRewardSummarizer(string sqliteFile)
    {
        _con = new SqliteConnection($"Data Source={sqliteFile}");
        _con.Open();

        using (var reader = new StreamReader("csv_data/item_id.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                if (!_itemidToName.ContainsKey(csv.GetField(0)))
                _itemidToName.Add(csv.GetField(0), csv.GetField(1));
            }
        }
    }

    public Dictionary<string, string> _enemyIdToName = new()
    {
        { "EM0500", "Quakadile" },
        { "EM0501", "Blizzadile" },
        { "EM0502", "Infernadile" },
        { "EM1700", "Behemoth" },
        { "EM1900", "Tayu'itar" },
        { "EM1800", "Ancient Dragon" },
        { "EM1801", "Vrazarek Firewyrm" },
        { "EM1802", "Wilinus Icewyrm" },
        { "EM1803", "Corvell Earthwyrm" },
        { "EM1804", "Elusious Windwyrm" },
        { "EM1805", "Radis Whitewyrm" },
        { "EM1806", "Ancient Dragon" },
        { "EM7500", "Angra Mainyu" },
        { "EM7600", "Bahamut Versa" },
        { "EM3100", "Pyet-A" },
        { "EM7100", "Proto Bahamut" },
    };

    // To be filled
    public Dictionary<string, string[]> _enemyPartToName = new()
    {
        { "EM3100", ["Tail", "Right Leg", null, null, null, null, "Face"] },
    };

    public Dictionary<string, Enemy> Enemies = [];

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM enemy_parts";
        var reader = com.ExecuteReader();

        while (reader.Read())
        {
            string key = (string)reader["Key"];
            if (string.IsNullOrEmpty(key))
                continue;

            if (!Enemies.TryGetValue(key, out Enemy enemy))
            {
                enemy = new Enemy();
                enemy.Key = key;
                Enemies.Add(key, enemy);
            }

            var breakPart = new EnemyBreakParts();
            breakPart.UnkFlag = (int)(long)reader["UnkFlag"];

            for (int i = 0; i < 3; i++)
            {
                int idx = (int)(long)reader[$"BodyPartIndex{i+1}"];
                if (idx != -1)
                    breakPart.BodyPartIndices.Add(idx);

                Reward reward = GetReward((string)reader[$"BodyPartRewardId{i + 1}"]);
                if (reward is not null)
                    breakPart.RewardPerPart.Add(reward);
            }

            enemy.BreakParts.Add(breakPart);
        }
    }

    public Reward GetReward(string id)
    {
        if (string.IsNullOrEmpty(id))
            return null;

        var com = _con.CreateCommand();
        com.CommandText = $"SELECT * FROM reward WHERE Key = '{id}'";
        var reader = com.ExecuteReader();

        var reward = new Reward();

        while (reader.Read())
        {
            for (int i = 0; i < 6; i++)
            {
                string lotId = (string)reader[$"RewardLotId{i + 1}"];
                if (string.IsNullOrEmpty(lotId))
                    continue;

                reward.Lots.Add(GetRewardLot(lotId));
            }
        }

        return reward;
    }

    public RewardLot GetRewardLot(string id)
    {
        if (string.IsNullOrEmpty(id))
            return null;

        var com = _con.CreateCommand();
        com.CommandText = $"SELECT * FROM reward_lot WHERE Key = '{id}'";
        var reader = com.ExecuteReader();

        var rewardLot = new RewardLot();
        while (reader.Read())
        {
            string itemId1 = (string)reader["ItemId"];
            string itemId2 = (string)reader["WeaponId"];
            string itemId3 = (string)reader["GemId"];
            int weight = (int)(long)reader["Weight"];
            int count = (int)(long)reader["AmountGiven"];
            int rewardRank = (int)(long)reader["RewardRank"];

            var reward = new RewardItem()
            {
                ItemId = !string.IsNullOrEmpty(itemId1) ? itemId1 :
                         !string.IsNullOrEmpty(itemId2) ? itemId2 :
                         !string.IsNullOrEmpty(itemId3) ? itemId3 :
                         "",
                Weight = weight,
                Count = count,
                RewardRank = rewardRank,
            };

            rewardLot.Items.Add(reward);
        }

        return rewardLot;
    }

    
    public void DescribeAllQuestRewards(StreamWriter sw)
    {
        foreach (var enemy in Enemies)
        {
            DescribeEnemy(sw, enemy.Value);
            sw.WriteLine("----\n");
        }
    }

    public void DescribeEnemy(StreamWriter sw, Enemy enemy)
    {
        if (_enemyIdToName.TryGetValue(enemy.Key, out string value))
            sw.WriteLine($"## {value} ({enemy.Key})");
        else
            sw.WriteLine($"## {enemy.Key}");

        for (int i = 0; i < enemy.BreakParts.Count; i++)
        {
            EnemyBreakParts parts = enemy.BreakParts[i];
            sw.WriteLine($"### Part Group #{i + 1}");
            sw.WriteLine($"UnkFlag/Id: {parts.UnkFlag}");

            for (int j = 0; j < parts.BodyPartIndices.Count; j++)
            {
                int bodyPartIdx = parts.BodyPartIndices[j];
                Reward reward = parts.RewardPerPart[j];

                sw.Write($"#### Body Part {bodyPartIdx}");
                if (_enemyPartToName.TryGetValue(enemy.Key, out string[] names))
                {
                    if (!string.IsNullOrEmpty(names[bodyPartIdx]))
                        sw.Write($" ({names[bodyPartIdx]})");
                }
                sw.WriteLine();

                if (reward.Lots.Count != 1)
                    Console.WriteLine($"Warning: {enemy.Key} has reward with lot count != 1");

                if (reward.Lots.Count > 0)
                    DescribeRewardLot(sw, reward.Lots[0]);
            }
        }
    }

    public void DescribeRewardLot(StreamWriter sw, RewardLot lot)
    {
        int totalWeight = lot.Items.Sum(e => e.Weight);

        var groups = lot.Items.GroupBy(e => e.RewardRank);
        sw.WriteLine("```");

        foreach (RewardItem item in lot.Items.OrderBy(e => e.RewardRank).ThenByDescending(e => e.Weight))
        {
            sw.WriteLine($"  - [R{item.RewardRank}] {_itemidToName[item.ItemId]} ({item.Weight})");
        }

        sw.WriteLine("```\n");
    }

    public class Enemy
    {
        public string Key { get; set; }
        public List<EnemyBreakParts> BreakParts { get; set; } = [];
    }

    public class EnemyBreakParts
    {
        public List<int> BodyPartIndices { get; set; } = [];
        public List<Reward> RewardPerPart { get; set; } = [];
        public int UnkFlag { get; set; }
    }

    public class Reward
    {
        public List<RewardLot> Lots { get; set; } = [];
    }

    public class RewardLot
    {
        public List<RewardItem> Items { get; set; } = [];
    }

    public class RewardItem
    {
        public string ItemId { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }
        public int RewardRank { get; set; }

        public override string ToString()
        {
            return $"x{Count} {ItemId} ({Weight})";
        }
    }
}
