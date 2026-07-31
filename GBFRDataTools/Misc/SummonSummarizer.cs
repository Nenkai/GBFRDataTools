using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using CsvHelper;

using Microsoft.Data.Sqlite;

using GBFRDataTools.Misc.Entities.Summons;

namespace GBFRDataTools.Misc;

/*
SummonSumarizer sum = new SummonSumarizer(@"db.sqlite");
sum.Load();

using (var sw = File.CreateText("summon_chances.md"))
    sum.Summarize(sw);
*/

public class SummonSumarizer
{
    private SqliteConnection _con;

    public List<Summon> Summons { get; set; } = [];

    public SummonSumarizer(string sqliteFile)
    {
        _con = new SqliteConnection($"Data Source={sqliteFile}");
        _con.Open();

        
    }

    public void Load()
    {
        var com = _con.CreateCommand();
        com.CommandText = "SELECT * FROM summon ORDER BY SortOrderMaybe";
        var reader = com.ExecuteReader();

        while (reader.Read())
        {
            string key = (string)reader["Key"];
            if (string.IsNullOrEmpty(key))
                continue;

            var summon = new Summon()
            {
                Key = key,
                Name = SummonsUtil.SummonNames[key],
                ChanceMainTraitSummonLot = SummonsUtil.GetSummonLot(_con, (string)reader["ChanceMainTraitSummonLotId"]),
                GuaranteedMainTraitSummonLot = SummonsUtil.GetSummonLot(_con, (string)reader["GuaranteedMainTraitSummonLotId"]),
                ChanceEquipBonusSummonLot = SummonsUtil.GetEquipBonusSummonLot(_con, (string)reader["ChanceEquipBonusSummonLotId"]),
                GuaranteedEquipBonusSummonLot = SummonsUtil.GetEquipBonusSummonLot(_con, (string)reader["GuaranteedEquipBonusSummonLotId"])
            };
            Summons.Add(summon);
        }
    }

    public void Summarize(StreamWriter sw)
    {
        foreach (var summon in Summons)
        {
            if (summon.GuaranteedEquipBonusSummonLot is not null || summon.GuaranteedMainTraitSummonLot is not null)
                continue; // We don't care for summons that have fixed rewards.

            //sw.WriteLine($"### {summon.Name} ({summon.Key})");
            sw.WriteLine($"### {summon.Name}");

            sw.WriteLine("```");
            if (summon.ChanceMainTraitSummonLot is not null)
            {
                SummonLot lot = summon.ChanceMainTraitSummonLot;

                //sw.WriteLine($"[Main Traits ({lot.Key})]");
                sw.WriteLine($"[Main Traits]");

                foreach (var choice in lot.Choices)
                {
                    int totalWeight = choice.Curves.Sum(e => e.Weight);
                    if (choice.Curves.Count == 1)
                    {
                        sw.WriteLine($"* {choice.SkillName} Lv{choice.Curves[0].SkillOrBaseParamLevel} ({(choice.Weight / (float)lot.TotalWeight) * 100:F2}%)");
                    }
                    else
                    {
                        sw.WriteLine($"* {choice.SkillName} ({(choice.Weight / (float)lot.TotalWeight) * 100:F2}%)");
                        string levels = string.Join(" / ", choice.Curves.Select(e => $"Lv{e.SkillOrBaseParamLevel} ({(e.Weight / (float)totalWeight) * 100:F2}%)"));
                        sw.WriteLine($"  - {levels}");
                    }
                }

                sw.WriteLine();
            }


            if (summon.ChanceEquipBonusSummonLot is not null)
            {
                EquipBonusSummonLot eqLot = summon.ChanceEquipBonusSummonLot;
                //sw.WriteLine($"[Equip Bonuses] ({eqLot.Key})");
                sw.WriteLine($"[Equip Bonuses]");

                foreach (var choice in eqLot.Choices)
                {
                    int totalWeight = choice.Curves.Sum(e => e.Weight);
                    if (choice.Curves.Count == 1)
                    {
                        sw.WriteLine($"* {choice.ParamName} Lv{choice.Curves[0].SkillOrBaseParamLevel} ({(choice.Weight / (float)eqLot.TotalWeight) * 100:F2}%)");
                    }
                    else
                    {
                        sw.WriteLine($"* {choice.ParamName} ({(choice.Weight / (float)eqLot.TotalWeight) * 100:F2}%)");

                        string levels = string.Join(" / ", choice.Curves.Select(e =>
                        {
                            float actualValue = choice.SummonBaseParam.ValuesPerLevel[e.SkillOrBaseParamLevel];
                            actualValue *= choice.SummonBaseParam.ValueDisplayMultiplier;

                            string valueStr;

                            if (choice.ParamName.Contains("Health Up") ||
                                choice.ParamName.Contains("Stun Power Up") ||
                                choice.ParamName.Contains("Attack Power Up"))
                                valueStr = $"+{(int)actualValue}";
                            else
                                valueStr = $"+{(int)actualValue}%";

                            return $"{valueStr} ({(e.Weight / (float)totalWeight) * 100:F2}%)";
                        }));

                        sw.WriteLine($"  - {levels}");
                    }
                }
            }
            sw.WriteLine("```\n");
        }
    }
}
