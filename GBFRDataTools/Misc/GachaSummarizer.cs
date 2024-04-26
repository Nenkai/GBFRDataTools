using Microsoft.Data.Sqlite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace GBFRDataTools.Misc;

public class GachaSummarizer
{
    private SqliteConnection _con;

    private Dictionary<uint, string> _questIdToName { get; } = [];
    private Dictionary<string, string> _itemidToName = [];

    public GachaSummarizer(string sqliteFile)
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

    public Dictionary<string, GachaTier> GachaTiers = [];

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM gacha";
        var reader = com.ExecuteReader();

        int tier = 1;
        while (reader.Read())
        {
            string key = (string)reader["Key"];
            string gemRateGroup = (string)reader["GemRateGroup"];
            string stoneRateGroup = (string)reader["WrightstoneRateGroup"];
            int gemChancePercent = (int)(long)reader["GemChancePercent"];
            int stoneChancePercent = (int)(long)reader["WrightstoneChancePercent"];
            uint unlockQuestId = uint.Parse((string)reader["UnlockQuestID"], NumberStyles.HexNumber);

            if (string.IsNullOrEmpty(key))
                continue;

            if (!GachaTiers.TryGetValue(key, out GachaTier gachaTier))
            {
                gachaTier = new GachaTier();
                gachaTier.GemRateGroup = gemRateGroup;
                gachaTier.Tier = tier;
                gachaTier.GemChancePercent = gemChancePercent;
                gachaTier.WrightstoneChancePercent = stoneChancePercent;
                gachaTier.UnlockQuestID = unlockQuestId;
                GachaTiers.Add(key, gachaTier);
            }

            ExtractRateGroup(gachaTier, gemRateGroup);
            ExtractRateGroup(gachaTier, stoneRateGroup, isStone: true);

            tier++;
        }
    }

    private void ExtractRateGroup(GachaTier gachaTier, string rateGroupId, bool isStone = false)
    {
        var com2 = _con.CreateCommand();
        com2.CommandText = $"SELECT * FROM gacha_rate_group WHERE Key = '{rateGroupId}'";
        var reader2 = com2.ExecuteReader();
        while (reader2.Read())
        {
            var rateGroup = new RateGroup();

            string gachaLotId = (string)reader2["GachaLotId"];
            rateGroup.Weight = (int)(long)reader2["Weight"];
            rateGroup.Flag = (int)(long)reader2["Unk4"];


            var com3 = _con.CreateCommand();
            com3.CommandText = $"SELECT * FROM gacha_lot WHERE Key = '{gachaLotId}'";
            var reader3 = com3.ExecuteReader();

            while (reader3.Read())
            {
                string itemId1 = (string)reader3["ItemId"];
                uint questMin = uint.Parse((string)reader3["QuestIDMin"], NumberStyles.HexNumber);
                uint questMax = uint.Parse((string)reader3["QuestIDMax"], NumberStyles.HexNumber);
                int traitChancePercentMaybe = (int)(long)reader3["Weight"];
                int traitLevel = (int)(long)reader3["TraitLevel"];

                var reward = new Reward()
                {
                    ItemId = itemId1,
                    QuestMin = questMin,
                    QuestMax = questMax,
                    Weight = traitChancePercentMaybe,
                    TraitLevel = traitLevel,
                };
                rateGroup.Rewards.Add(reward);
            }

            if (isStone)
                gachaTier.StoneGroups.Add(rateGroup);
            else
                gachaTier.GemGroups.Add(rateGroup);
        }
    }

    public void DescribeAllGachaTiers(StreamWriter sw)
    {
        foreach (var q in GachaTiers)
        {
            DescribeGachaTier(sw, q.Key);
            sw.WriteLine("----\n");
        }
    }

    public void DescribeGachaTier(StreamWriter sw, string tierId)
    {
        GachaTier tier = GachaTiers[tierId];

        int totalWeight = tier.GemGroups.Sum(e => e.Weight);
        string name = $"Level {tier.Tier} Transmutation";
        if (tier.Tier == 4)
            name = "Transmarvel";

        sw.WriteLine($"## {name} (Total Weight: {totalWeight})");
        sw.WriteLine($"- Gem (Sigil) Chance: **{tier.GemChancePercent}%**");
        sw.WriteLine($"- Stone Chance: **{tier.WrightstoneChancePercent}%**");
        sw.WriteLine($"- Unlock Requirement: **{QuestToString(tier.UnlockQuestID)}**");
        sw.WriteLine();

        sw.WriteLine("### :simple-rubygems: Gem/Sigils");

        for (int i = 0; i < tier.GemGroups.Count; i++)
        {
            RateGroup group = tier.GemGroups[i];
            float percent = ((float)group.Weight / totalWeight) * 100;

            sw.WriteLine($"#### Gem Group #{i + 1} ({percent:N2}%, weight {group.Weight})");
            if (group.Rewards.Count == 0)
            {
                sw.WriteLine("(Empty)\n");
            }
            else
            {
                sw.WriteLine("```");

                int rewardTotalWeight = group.Rewards.Sum(e => e.Weight);

                for (int j = 0; j < group.Rewards.Count; j++)
                {
                    Reward reward = group.Rewards[j];
                    float rewardPrcent = ((float)reward.Weight / rewardTotalWeight) * 100;

                    string itemName = _itemidToName[reward.ItemId];
                    sw.Write($"  - {itemName}");
                    if (reward.TraitLevel != 0)
                        sw.Write($" Lvl.{reward.TraitLevel}");

                    sw.Write($" ({rewardPrcent:N2}%, weight {reward.Weight})");

                    if (reward.QuestMin != 0)
                        sw.Write($" (Starting {QuestToString(reward.QuestMin)})");
                    if (reward.QuestMax != 0)
                        sw.Write($" (Until {QuestToString(reward.QuestMax)})");

                    sw.WriteLine();
                }
                sw.WriteLine("```\n");
            }
        }

        sw.WriteLine("### :material-diamond-stone: Stones");

        for (int i = 0; i < tier.StoneGroups.Count; i++)
        {
            RateGroup group = tier.StoneGroups[i];

            float percent = ((float)group.Weight / totalWeight) * 100;

            sw.WriteLine($"#### Stone Group #{i + 1} ({percent:N2}%, weight {group.Weight})");
            sw.WriteLine("```");

            for (int j = 0; j < group.Rewards.Count; j++)
            {
                Reward reward = group.Rewards[j];

                string itemName = _itemidToName.ContainsKey(reward.ItemId) ? _itemidToName[reward.ItemId] : reward.ItemId;
                sw.WriteLine($"  - {itemName}");
            }
            sw.WriteLine("```\n");
        }
    }

    public static string QuestToString(uint qId)
    {
        switch (qId)
        {
            case 0x00404101:
                return "Very Hard Unlocked";

            case 0x0010A002:
                return "Extreme Unlocked";

            case 0x0010A031:
                return "Maniac Unlocked";

            case 0x00407101:
                return "Proud Unlocked";

            default:
                return $"Quest {qId:X8}";
        }
    }


    public class GachaTier
    {
        public int Tier { get; set; }
        public int GemChancePercent { get; set; }
        public int WrightstoneChancePercent { get; set; }
        public string GemRateGroup { get; set; }
        public uint UnlockQuestID { get; set; }
        public List<RateGroup> GemGroups { get; set; } = [];
        public List<RateGroup> StoneGroups { get; set; } = [];
    }

    public class RateGroup
    {
        public int Weight { get; set; }
        public int Flag { get; set; }
        public List<Reward> Rewards { get; set; } = [];
    }

    public class Reward
    {
        public string ItemId { get; set; }
        public uint QuestMin { get; set; }
        public uint QuestMax { get; set; }
        public int Weight { get; set; }
        public int TraitLevel { get; set; }

        public override string ToString()
        {
            return $"{ItemId}";
        }
    }
}
