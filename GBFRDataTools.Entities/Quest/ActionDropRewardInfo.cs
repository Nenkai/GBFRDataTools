using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

/// <summary>
/// stage::quest::ActionDropRewardInfo
/// </summary>
public class ActionDropRewardInfo
{
    public List<string> RewardLabels { get; set; } = [];

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "rewardLabel_":
                    {
                        RewardLabels.Add(reader.ReadString());
                    }
                    break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for ActionDropRewardInfo");
            }
        }
    }
}
