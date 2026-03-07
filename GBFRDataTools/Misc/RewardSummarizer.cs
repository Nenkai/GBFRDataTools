using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

using MessagePack;
using System.Text.Json;
using GBFRDataTools.Misc.Entities;
using System.Formats.Asn1;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Misc;

public class RewardSummarizer
{
    private SqliteConnection _con;

    private Dictionary<uint, string> _questIdToName { get; } = [];
    private Dictionary<string, string> _itemidToName = [];
    private Dictionary<uint, QuestBaseInfo> _questInfos { get; } = [];
    private Dictionary<string, string> _stageKeys { get; } = [];

    public RewardSummarizer(string sqliteFile, string extractedDir)
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
                if (uint.TryParse(csv.GetField(0), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint questId))
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

        // Parse submission (aka subgoal names)
        foreach (var questIdFolder in Directory.GetDirectories(Path.Combine(extractedDir, "quest")))
        {
            uint qid = uint.Parse(Path.GetFileName(questIdFolder), NumberStyles.HexNumber);
            if (qid < 0x400000)
                continue;

            byte[] baseInfoFile = File.ReadAllBytes(Path.Combine(questIdFolder, "baseinfo.msg"));
            string baseInfoJson = MessagePack.MessagePackSerializer.ConvertToJson(baseInfoFile);
            QuestBaseInfo baseInfo = JsonSerializer.Deserialize<QuestBaseInfo>(baseInfoJson);

            _questInfos.Add(qid, baseInfo);
        }

        byte[] textStageFile = File.ReadAllBytes(Path.Combine(extractedDir, "system", "table", "text", "en", "text_stage.msg"));
        string textStageStr = MessagePack.MessagePackSerializer.ConvertToJson(textStageFile);
        JsonDocument doc = JsonDocument.Parse(textStageStr);
        foreach (var elem in doc.RootElement.GetProperty("rows_").EnumerateArray())
        {
            var col = elem.GetProperty("column_");
            _stageKeys.Add(col.GetProperty("id_hash_").GetString(), col.GetProperty("text_").GetString());
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

            QuestReward questReward;
            if (key.Contains("SUBM"))
            {
                string[] spl = key.Split('_');
                if (spl.Length != 4)
                    continue;

                if (!uint.TryParse(spl[1], NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint questId))
                    continue;

                if (!int.TryParse(spl[3], out int number))
                    continue;

                if (!QuestRewards.TryGetValue(questId, out questReward))
                {
                    questReward = new QuestReward();
                    questReward.QuestId = questId;
                    QuestRewards.Add(questId, questReward);
                }

                List<RewardLot> lots = GetRewardLots(reader);
                RewardLot rewardPoint1 = GetRewardLot((string)reader["RewardPointId1"]);
                RewardLot rewardPoint2 = GetRewardLot((string)reader["RewardPointId2"]);
                RewardLot rewardPoint3 = GetRewardLot((string)reader["RewardPointId3"]);

                questReward.SubGoalRewards[number] = lots;
            }
            else
            {
                string[] spl = key.Split('_');
                if (spl.Length != 3)
                    continue;

                if (!uint.TryParse(spl[1], NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint questId))
                    continue;

                if (!int.TryParse(spl[2], out int type))
                    continue;

                if (!QuestRewards.TryGetValue(questId, out questReward))
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
            if (DescribeQuestRewards(sw, q.Key))
                sw.WriteLine("----\n");
        }
    }

    public bool DescribeQuestRewards(StreamWriter sw, uint questId)
    {
        QuestReward reward = QuestRewards[questId];
        if (!_questIdToName.ContainsKey(questId))
        {
            Console.WriteLine($"Skipping quest {questId:X6}, not in quest id database");
            return false;
        }

        string questName = _questIdToName[reward.QuestId];

        sw.WriteLine($"### {questName} ({reward.QuestId:X6})\n");
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

        bool hasSubGoalRewards = false;
        int i = -1;
        foreach (var subGoal in reward.SubGoalRewards)
        {
            i++;
            if (subGoal.Value.Any(e => e.Rewards.Count == 0 || string.IsNullOrEmpty(e.Rewards[0].ItemId))) // TODO: Figure out why some reward lots are empty?
                continue;

            if (!hasSubGoalRewards)
            {
                sw.WriteLine();
                sw.WriteLine("[Sub Missions Rewards]");
                hasSubGoalRewards = true;
            }

            if (_questInfos.TryGetValue(questId, out QuestBaseInfo baseInfo))
            {
                QuestBaseInfo questInfo = _questInfos[questId];
                string target = questInfo.subMissions_[i].target_;
                TargetList textLabel = questInfo.targetList_.FirstOrDefault(e => e.label_ == target);
                if (_stageKeys.TryGetValue(textLabel.textLabel_, out string subGoalDetail))
                {
                    string fmtStr = subGoalDetail.Contains("{maxcount}") ? "{maxcount}" :
                                    subGoalDetail.Contains("{maxcount_1}") ? "{maxcount_1}" :
                                    string.Empty;

                    if (!string.IsNullOrEmpty(fmtStr))
                    {
                        int type = int.Parse(textLabel.type_);
                        switch (type)
                        {
                            case 2: // Minutes
                                subGoalDetail = subGoalDetail.Replace(fmtStr, (int.Parse(textLabel.count_) / 60).ToString());
                                break;

                            case 7: // Percentage
                                subGoalDetail = subGoalDetail.Replace(fmtStr, ((int)(float.Parse(textLabel.count_) * 100)).ToString());
                                break;

                            default:
                                subGoalDetail = subGoalDetail.Replace(fmtStr, textLabel.count_);
                                break;
                        }
                    }

                    sw.Write($"{subGoalDetail}: ");
                }
                else
                    sw.Write($"Side Goal {i + 1}: ");
            }
            else
                sw.Write($"Side Goal {i + 1}: ");

            foreach (var r in subGoal.Value)
            {
                string itemName = _itemidToName[r.Rewards[0].ItemId];
                if (r.Rewards[0].ItemId.Contains("GEEN") || r.Rewards[0].ItemId.Contains("WEP_"))
                    sw.Write("- ");
                else
                    sw.Write($"- x{r.Rewards[0].Count} ");
                sw.Write(itemName);
                sw.WriteLine();
            }
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

        return true;
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
        public Dictionary<int, List<RewardLot>> SubGoalRewards { get; set; } = new();
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
