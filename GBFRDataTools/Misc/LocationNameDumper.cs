using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Quest;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class LocationNameDumper
{
    public static void Dump(string systemTableTextDirPath)
    {
        Dictionary<string, string> _locationTextKeys = new()
        {
            ["LOCATION_TST_01"] = "TXT_LOCATION_00",
            ["LOCATION_TST_02"] = "TXT_LOCATION_01",
            ["LOCATION_1ST_01"] = "TXT_LOCATION_03",
            ["LOCATION_1ST_02"] = "TXT_LOCATION_04",
            ["LOCATION_1ST_03"] = "TXT_LOCATION_05",
            ["LOCATION_1ST_04"] = "TXT_LOCATION_32",
            ["LOCATION_1ST_05"] = "TXT_LOCATION_00",
            ["LOCATION_2ST_01"] = "TXT_LOCATION_31",
            ["LOCATION_2ST_02"] = "TXT_LOCATION_07",
            ["LOCATION_3ST_01"] = "TXT_LOCATION_08",
            ["LOCATION_3ST_02"] = "TXT_LOCATION_09",
            ["LOCATION_3ST_03"] = "TXT_LOCATION_11",
            ["LOCATION_3ST_04"] = "TXT_LOCATION_13",
            ["LOCATION_4ST_01"] = "TXT_LOCATION_14",
            ["LOCATION_4ST_02"] = "TXT_LOCATION_15",
            ["LOCATION_5ST_01"] = "TXT_LOCATION_15",
            ["LOCATION_5ST_02"] = "TXT_LOCATION_33",
            ["LOCATION_6ST_01"] = "TXT_LOCATION_18",
            ["LOCATION_6ST_02"] = "TXT_LOCATION_33",
            ["LOCATION_6ST_03"] = "TXT_QUEST_STAGE_NAME_7ST",
            ["LOCATION_6ST_04"] = "TXT_QUEST_STAGE_NAME_7ST",
            ["LOCATION_7ST_01"] = "TXT_QUEST_STAGE_NAME_7ST",
            ["LOCATION_7ST_02"] = "TXT_QUEST_STAGE_NAME_7ST",
            ["LOCATION_7ST_03"] = "TXT_LOCATION_20",
            ["LOCATION_7ST_04"] = "TXT_LOCATION_06",
            ["LOCATION_8ST_01"] = "TXT_LOCATION_NOTHING",
        };

        foreach (var localeDir in Directory.GetDirectories(systemTableTextDirPath))
        {
            string locale = Path.GetFileName(localeDir);
            var textTelop = TextDataFile.Read(File.ReadAllBytes(Path.Combine(localeDir, "text_telop.msg")), isMessagePackFile: true);
            var textUi = TextDataFile.Read(File.ReadAllBytes(Path.Combine(localeDir, "text_ui.msg")), isMessagePackFile: true);

            var allRows = textTelop.Rows.Concat(textUi.Rows);
            Console.WriteLine($"// {locale}");
            Console.WriteLine($"IslandLocationKey,TextKey,Name");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            foreach (var k in _locationTextKeys)
            {
                foreach (var row in allRows)
                {
                    if (row.Id_hash == k.Value)
                    {
                        Console.WriteLine($"{k.Key},{k.Value},\"{row.Text}\"");
                    }
                }

                ;
            }

            Console.WriteLine();
        }
    }
}
