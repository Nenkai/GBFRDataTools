using GBFRDataTools.Entities.Quest;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class QuestLocationDumper
{
    public static void Dump(string questDirPath)
    {
        Dictionary<string, string> _locationsIcons = new()
        {
            ["LOCATION_TST_01"] = "location_00",
            ["LOCATION_TST_02"] = "location_01",
            ["LOCATION_1ST_01"] = "location_02",
            ["LOCATION_1ST_02"] = "location_03",
            ["LOCATION_1ST_03"] = "location_04",
            ["LOCATION_1ST_04"] = "location_24",
            ["LOCATION_1ST_05"] = "location_05",
            ["LOCATION_2ST_01"] = "location_06",
            ["LOCATION_2ST_02"] = "location_07",
            ["LOCATION_3ST_01"] = "location_08",
            ["LOCATION_3ST_02"] = "location_09",
            ["LOCATION_3ST_03"] = "location_10",
            ["LOCATION_3ST_04"] = "location_11",
            ["LOCATION_4ST_01"] = "location_12",
            ["LOCATION_4ST_02"] = "location_13",
            ["LOCATION_5ST_01"] = "location_14",
            ["LOCATION_5ST_02"] = "location_15",
            ["LOCATION_6ST_01"] = "location_16",
            ["LOCATION_6ST_02"] = "location_17",
            ["LOCATION_6ST_03"] = "location_18",
            ["LOCATION_6ST_04"] = "location_30",
            ["LOCATION_7ST_01"] = "location_19",
            ["LOCATION_7ST_02"] = "location_19",
            ["LOCATION_7ST_03"] = "location_19",
            ["LOCATION_7ST_04"] = "location_20",
            ["LOCATION_8ST_01"] = "location_21",
        };

        foreach (var questDir in Directory.GetDirectories(questDirPath))
        {
            string questIdStr = Path.GetFileName(questDir);
            if (!questIdStr.StartsWith("4"))
                continue;

            var baseInfo = BaseInfo.Read(File.ReadAllBytes(Path.Combine(questDir, "baseinfo.msg")));
            Console.WriteLine($"{int.Parse(questIdStr, NumberStyles.HexNumber, null):X6},{baseInfo.Multi.Location},{_locationsIcons[baseInfo.Multi.Location]}");
        }
    }
}
