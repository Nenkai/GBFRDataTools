using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class MultiInfo
{
    public int StrengthValue { get; set; }
    public int RecommendedCombatPower { get; set; }
    public string IslandId { get; set; }
    public int GameCategory { get; set; }
    public int MultiQuestType { get; set; }
    public string Location { get; set; }

    // enemyIds_[{0}], enemyNum_[{0}], overwriteStatusAndReward_[{}]
    public List<int> EnemyIds { get; set; } = [];
    public List<int> EnemyNum { get; set; } = [];
    public List<uint> OverwriteStatusAndReward { get; set; } = [];

    public float Min { get; set; }
    public float Max { get; set; }
    public float Standard { get; set; }
    public bool HasPrepareArea { get; set; }
    public bool IsQuestStartFromBossAppear { get; set; }
    public TargetDispInfo TargetDispInfo { get; set; }
    public bool IsUltimateParameterUse { get; set; }
    public bool IsBossRush { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "strengthValue_":
                    StrengthValue = int.Parse(reader.ReadString()); break;
                case "rcommendedCombatPower_":
                    RecommendedCombatPower = int.Parse(reader.ReadString()); break;
                case "islandId_":
                    IslandId = reader.ReadString(); break;
                case "gameCategory_":
                    GameCategory = int.Parse(reader.ReadString()); break;
                case "multiQuestType_":
                    MultiQuestType = int.Parse(reader.ReadString()); break;
                case "location_":
                    Location = reader.ReadString(); break;
                case "min_":
                    Min = float.Parse(reader.ReadString()); break;
                case "max_":
                    Max = float.Parse(reader.ReadString()); break;
                case "standard_":
                    Standard = float.Parse(reader.ReadString()); break;
                case "hasPrepareArea_":
                    HasPrepareArea = bool.Parse(reader.ReadString()); break;
                case "isQuestStartFromBossAppear_":
                    IsQuestStartFromBossAppear = bool.Parse(reader.ReadString()); break;
                case "targetDispInfo_":
                    TargetDispInfo = new TargetDispInfo();
                    TargetDispInfo.Read(ref reader);
                    break;
                case "isUltimateParameterUse_":
                    IsUltimateParameterUse = bool.Parse(reader.ReadString()); break;
                case "isBossRush_":
                    IsBossRush = bool.Parse(reader.ReadString()); break;

                default:
                    if (key.StartsWith("enemyIds_"))
                        EnemyIds.Add(int.Parse(reader.ReadString()));
                    else if (key.StartsWith("enemyNum_"))
                        EnemyNum.Add(int.Parse(reader.ReadString()));
                    else if (key.StartsWith("overwriteStatusAndReward_"))
                        OverwriteStatusAndReward.Add(uint.Parse(reader.ReadString()));
                    else
                        throw new NotImplementedException($"Property '{key}' not supported for MultiInfo");
                    break;
            }
        }
    }
}
