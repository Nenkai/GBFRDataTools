using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GBFRDataTools.Misc;

public class RewardSummarizer
{
    private SqliteConnection _con;

    private Dictionary<uint, string> _questIdToName { get; } = [];
    private Dictionary<string, string> _itemidToName = [];

    public RewardSummarizer(string sqliteFile)
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

    public Dictionary<uint, QuestReward> QuestRewards = [];

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM reward";
        var reader = com.ExecuteReader();

        while (reader.Read())
        {
            string key = (string)reader["Key"];
            if (string.IsNullOrEmpty(key))
                continue;

            string[] spl = key.Split('_');
            if (spl.Length != 3)
                continue;

            if (!uint.TryParse(spl[1], out uint questId))
                continue;

            if (!int.TryParse(spl[2], out int type))
                continue;

            if (!QuestRewards.TryGetValue(questId, out QuestReward questReward))
            {
                questReward = new QuestReward();
                questReward.QuestId = questId;
                QuestRewards.Add(questId, questReward);
            }

            List<RewardLot> lots = GetRewardLots(reader);
            RewardLot rewardPoint1 = GetRewardLot((string)reader["RewardPointId1"]);
            RewardLot rewardPoint2 = GetRewardLot((string)reader["RewardPointId2"]);
            RewardLot rewardPoint3 = GetRewardLot((string)reader["RewardPointId3"]);

            switch (type)
            {
                case 100:
                    questReward.FirstClearRewards = lots;
                    break;

                case 101:
                    questReward.ClearRewards = lots;
                    break;

                case 301:
                    questReward._1Star = lots;
                    break;

                case 302:
                    questReward._2Stars = lots;
                    break;

                case 303:
                    questReward._3Stars = lots;
                    break;

                case 304:
                    questReward._4Stars = lots;
                    break;

                case 305:
                    questReward._5Stars = lots;
                    break;

                case 400:
                    questReward.ClearChest = lots;
                    break;

                case 401:
                    questReward._1StarChest = lots;
                    break;

                case 402:
                    questReward._2StarsChest = lots;
                    break;

                case 403:
                    questReward._3StarsChest = lots;
                    break;

                case 404:
                    questReward._4StarsChest = lots;
                    break;

                case 405:
                    questReward._5StarsChest = lots;
                    break;
            }
        }
    }

    public List<RewardLot> GetRewardLots(SqliteDataReader reader)
    {
        string lot1 = (string)reader["RewardLotId1"];
        string lot2 = (string)reader["RewardLotId2"];
        string lot3 = (string)reader["RewardLotId3"];
        string lot4 = (string)reader["RewardLotId4"];
        string lot5 = (string)reader["RewardLotId5"];
        string rewardPointId1 = (string)reader["RewardPointId1"];
        string rewardPointId2 = (string)reader["RewardPointId2"];
        string rewardPointId3 = (string)reader["RewardPointId3"];

        RewardLot lot1_ = GetRewardLot(lot1);
        RewardLot lot2_ = GetRewardLot(lot2);
        RewardLot lot3_ = GetRewardLot(lot3);
        RewardLot lot4_ = GetRewardLot(lot4);
        RewardLot lot5_ = GetRewardLot(lot5);
        RewardLot rewardPoint1_ = GetRewardLot(rewardPointId1);
        RewardLot rewardPoint2 = GetRewardLot(rewardPointId2);
        RewardLot rewardPoint3 = GetRewardLot(rewardPointId3);

        List<RewardLot> lots = new List<RewardLot>();
        if (lot1_ is not null)
            lots.Add(lot1_);

        if (lot2_ is not null)
            lots.Add(lot2_);

        if (lot3_ is not null)
            lots.Add(lot3_);

        if (lot4_ is not null)
            lots.Add(lot4_);

        if (lot5_ is not null)
            lots.Add(lot5_);

        return lots;
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

            var reward = new Reward()
            {
                ItemId = !string.IsNullOrEmpty(itemId1) ? itemId1 :
                         !string.IsNullOrEmpty(itemId2) ? itemId2 :
                         !string.IsNullOrEmpty(itemId3) ? itemId3 :
                         "",
                Weight = weight,
                Count = count,
            };

            rewardLot.Rewards.Add(reward);
        }

        return rewardLot;
    }

    public void DescribeAllQuestRewards(StreamWriter sw)
    {
        foreach (var q in QuestRewards)
        {
            DescribeQuestRewards(sw, q.Key);
            sw.WriteLine("----\n");
        }
    }

    public void DescribeQuestRewards(StreamWriter sw, uint questId)
    {
        QuestReward reward = QuestRewards[questId];
        string questName = _questIdToName[reward.QuestId];

        sw.WriteLine($"## {questName} ({reward.QuestId})\n");
        sw.WriteLine("```");

        sw.WriteLine($"First Clear Rewards:");
        foreach (var r in reward.FirstClearRewards)
        {
            string itemName = _itemidToName[r.Rewards[0].ItemId];
            if (r.Rewards[0].ItemId.Contains("GEEN") || r.Rewards[0].ItemId.Contains("WEP_"))
                sw.Write("- ");
            else
                sw.Write($"- x{r.Rewards[0].Count} ");
            sw.WriteLine(itemName);
        }

        sw.WriteLine();
        if (reward.ClearRewards is not null)
        {
            sw.WriteLine("[Clear Rewards]");

            if (reward.ClearRewards.Count > 0)
                DescribeRewardLot(sw, reward.ClearRewards);

            if (reward.ClearChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward.ClearChest);
            }
        }

        if (reward._1Star.Count > 0 || reward._1StarChest.Count > 0)
        {
            sw.WriteLine("[1 ★☆☆☆☆ (B Rank)]");

            if (reward._1Star.Count > 0)
                DescribeRewardLot(sw, reward._1Star);

            if (reward._1StarChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward._1StarChest);
            }
        }

        if (reward._2Stars.Count > 0 || reward._2StarsChest.Count > 0)
        {
            sw.WriteLine("[2 ★★☆☆☆ (A Rank)]");

            if (reward._2Stars.Count > 0)
                DescribeRewardLot(sw, reward._2Stars);

            if (reward._2StarsChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward._2StarsChest);
            }
        }

        if (reward._3Stars.Count > 0 || reward._3StarsChest.Count > 0)
        {
            sw.WriteLine("[3 ★★★☆☆ (S Rank)]");

            if (reward._3Stars.Count > 0)
                DescribeRewardLot(sw, reward._3Stars);

            if (reward._3StarsChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward._3StarsChest);
            }
        }

        if (reward._4Stars.Count > 0 || reward._4StarsChest.Count > 0)
        {
            sw.WriteLine("[4 ★★★★☆ (S+ Rank)]");

            if (reward._4Stars.Count > 0)
                DescribeRewardLot(sw, reward._4Stars);

            if (reward._4StarsChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward._4StarsChest);
            }
        }

        if (reward._5Stars.Count > 0 || reward._5StarsChest.Count > 0)
        {
            sw.WriteLine("[5 ★★★★★ (S++ Rank)]");

            if (reward._5Stars.Count > 0)
                DescribeRewardLot(sw, reward._5Stars);

            if (reward._5StarsChest.Count > 0)
            {
                sw.WriteLine("🎁 Chest");
                DescribeRewardLot(sw, reward._5StarsChest);
            }
        }


        sw.WriteLine("```\n");

    }

    private void DescribeRewardLot(StreamWriter sw, List<RewardLot> lots)
    {
        for (int i = 0; i < lots.Count; i++)
        {
            RewardLot lot = lots[i];
            int totalWeight = lot.Rewards.Sum(e => e.Weight);

            sw.WriteLine($"* Lot #{i + 1} (Total Weight: {totalWeight})");
            for (int j = 0; j < lot.Rewards.Count; j++)
            {
                Reward reward = lot.Rewards[j];
                if (string.IsNullOrEmpty(reward.ItemId))
                {
                    sw.WriteLine($"    - Nothing ({(float)reward.Weight / totalWeight * 100:0.##}% - {reward.Weight})");
                }
                else
                {
                    string itemName = _itemidToName[reward.ItemId];
                    if (reward.ItemId.Contains("GEEN") || reward.ItemId.Contains("WEP_"))
                        sw.Write("    - ");
                    else
                        sw.Write($"    - x{reward.Count} ");
                    sw.WriteLine($"{itemName} ({(float)reward.Weight / totalWeight * 100:0.##}% - {reward.Weight})");
                }

            }
        }

        sw.WriteLine();
    }

    public class QuestReward
    {
        public uint QuestId { get; set; }
        public List<RewardLot> FirstClearRewards { get; set; } = [];
        public List<RewardLot> ClearRewards { get; set; } = [];
        public List<RewardLot> ClearChest { get; set; } = [];
        public List<RewardLot> _1Star { get; set; } = [];
        public List<RewardLot> _2Stars { get; set; } = [];
        public List<RewardLot> _3Stars { get; set; } = [];
        public List<RewardLot> _4Stars { get; set; } = [];
        public List<RewardLot> _5Stars { get; set; } = [];
        public List<RewardLot> _1StarChest { get; set; } = [];
        public List<RewardLot> _2StarsChest { get; set; } = [];
        public List<RewardLot> _3StarsChest { get; set; } = [];
        public List<RewardLot> _4StarsChest { get; set; } = [];
        public List<RewardLot> _5StarsChest { get; set; } = [];

    }

    public class RewardLot
    {
        public List<Reward> Rewards { get; set; } = [];
    }

    public class Reward
    {
        public string ItemId { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"x{Count} {ItemId} ({Weight})";
        }
    }
}
