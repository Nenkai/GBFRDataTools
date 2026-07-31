using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using CsvHelper;

using GBFRDataTools.Misc.Entities.Summons;

using Microsoft.Data.Sqlite;

namespace GBFRDataTools.Misc;

public class SummonsUtil
{
    public static Dictionary<string, string> SummonNames = [];
    public static Dictionary<string, string> SkillNames = [];
    public static Dictionary<string, string> SummonBaseParamNames = [];

    static SummonsUtil()
    {
        using (var reader = new StreamReader("csv_data/summons.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                SummonNames.Add(csv.GetField(0), csv.GetField(2));
            }
        }

        using (var reader = new StreamReader("csv_data/skill_id.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                SkillNames.TryAdd(csv.GetField(0), csv.GetField(1));
            }
        }

        using (var reader = new StreamReader("csv_data/summon_base_param.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                SummonBaseParamNames.TryAdd(csv.GetField(0), csv.GetField(1));
            }
        }
    }

    public static Summon GetSummon(SqliteConnection connection, string key)
    {
        var com = connection.CreateCommand();
        com.CommandText = $"SELECT * FROM summon WHERE Key = '{key}'";
        var reader = com.ExecuteReader();

        reader.Read();
        if (reader.HasRows)
        {
            var summon = new Summon()
            {
                Key = key,
                Name = SummonsUtil.SummonNames[key],
                ChanceMainTraitSummonLot = SummonsUtil.GetSummonLot(connection, (string)reader["ChanceMainTraitSummonLotId"]),
                GuaranteedMainTraitSummonLot = SummonsUtil.GetSummonLot(connection, (string)reader["GuaranteedMainTraitSummonLotId"]),
                ChanceEquipBonusSummonLot = SummonsUtil.GetEquipBonusSummonLot(connection, (string)reader["ChanceEquipBonusSummonLotId"]),
                GuaranteedEquipBonusSummonLot = SummonsUtil.GetEquipBonusSummonLot(connection, (string)reader["GuaranteedEquipBonusSummonLotId"])
            };
            return summon;
        }

        return null;
    }

    public static SummonLot GetSummonLot(SqliteConnection connection, string key)
    {
        if (string.IsNullOrEmpty(key))
            return null;

        var com = connection.CreateCommand();
        com.CommandText = $"SELECT * FROM Summon_Lot WHERE Key = '{key}'";
        var reader = com.ExecuteReader();

        var summonLot = new SummonLot() { Key = key };

        while (reader.Read())
        {
            string skillId = (string)reader["SkillIdOrBaseParamId"];
            string curveId = (string)reader["SummonCurveId"];
            int weight = (int)(long)reader["Weight"];

            var reward = new SummonReward()
            {
                SkillId = skillId,
                SkillName = SkillNames.ContainsKey(skillId) ? SkillNames[skillId] : skillId,
                Weight = weight,
                Curves = GetCurve(connection, curveId),
            };

            summonLot.Choices.Add(reward);
        }

        summonLot.TotalWeight = summonLot.Choices.Sum(e => e.Weight);
        return summonLot;
    }

    public static EquipBonusSummonLot GetEquipBonusSummonLot(SqliteConnection connection, string key)
    {
        if (string.IsNullOrEmpty(key))
            return null;

        var com = connection.CreateCommand();
        com.CommandText = $"SELECT * FROM Summon_Lot WHERE Key = '{key}'";
        var reader = com.ExecuteReader();

        var summonLot = new EquipBonusSummonLot() { Key = key };

        while (reader.Read())
        {
            string baseParamId = (string)reader["SkillIdOrBaseParamId"];
            string curveId = (string)reader["SummonCurveId"];
            int weight = (int)(long)reader["Weight"];

            var reward = new EquipBonusSummonReward()
            {
                BaseParamKey = baseParamId,
                SummonBaseParam = GetSummonBaseParam(connection, baseParamId),
                ParamName = SummonBaseParamNames.ContainsKey(baseParamId) ? SummonBaseParamNames[baseParamId] : baseParamId,
                Weight = weight,
                Curves = GetCurve(connection, curveId),
            };

            summonLot.Choices.Add(reward);
        }

        summonLot.TotalWeight = summonLot.Choices.Sum(e => e.Weight);
        return summonLot;
    }

    public static SummonBaseParam GetSummonBaseParam(SqliteConnection connection, string key)
    {
        var com = connection.CreateCommand();
        com.CommandText = $"SELECT * FROM Summon_Base_Param WHERE Key = '{key}'";
        var reader = com.ExecuteReader();

        reader.Read();

        var summonBaseParam = new SummonBaseParam();
        for (int i = 0; i < 10; i++)
        {
            summonBaseParam.ValuesPerLevel[i] = (float)(double)reader[$"Level{i + 1}Value"];
        }

        summonBaseParam.ValueDisplayMultiplier = (int)(long)reader[$"ValueDisplayMultiplier"];
        return summonBaseParam;
    }

    public static List<SummonCurve> GetCurve(SqliteConnection connection, string key)
    {
        var com = connection.CreateCommand();
        com.CommandText = $"SELECT * FROM Summon_Curve WHERE Key = '{key}'";
        var reader = com.ExecuteReader();

        List<SummonCurve> curveList = [];
        while (reader.Read())
        {
            var summonCurve = new SummonCurve
            {
                SkillOrBaseParamLevel = (int)(long)reader[$"SkillOrBaseParamLevel"],
                Weight = (int)(long)reader[$"Weight"]
            };
            curveList.Add(summonCurve);
        }

        return curveList;
    }
}
