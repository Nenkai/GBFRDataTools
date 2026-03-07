using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class PlacementsInfo
{
    public int TreasureMaxCount { get; set; }
    public int TreasureMinCount { get; set; }
    public int PickMaxCount { get; set; }
    public int PickMinCount { get; set; }
    public int SearchItemMaxCount { get; set; }
    public int SearchItemMinCount { get; set; }
    public int ArchiveMaxCount { get; set; }
    public int ArchiveMinCount { get; set; }
    public int MultiQuestCoinMaxCount { get; set; }
    public int MultiQuestCoinMinCount { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "treasureMaxCount_":
                    TreasureMaxCount = int.Parse(reader.ReadString()); break;
                case "treasureMinCount_":
                    TreasureMinCount = int.Parse(reader.ReadString()); break;
                case "pickMaxCount_":
                    PickMaxCount = int.Parse(reader.ReadString()); break;
                case "pickMinCount_":
                    PickMinCount = int.Parse(reader.ReadString()); break;
                case "searchItemMaxCount_":
                    SearchItemMaxCount = int.Parse(reader.ReadString()); break;
                case "searchItemMinCount_":
                    SearchItemMinCount = int.Parse(reader.ReadString()); break;
                case "archiveMaxCount_":
                    ArchiveMaxCount = int.Parse(reader.ReadString()); break;
                case "archiveMinCount_":
                    ArchiveMinCount = int.Parse(reader.ReadString()); break;
                case "multiQuestCoinMaxCount_":
                    MultiQuestCoinMaxCount = int.Parse(reader.ReadString()); break;
                case "multiQuestCoinMinCount_":
                    MultiQuestCoinMinCount = int.Parse(reader.ReadString()); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for PlacementsInfo");
            }
        }
    }
}
