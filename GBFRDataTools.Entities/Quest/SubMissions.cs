using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

public class SubMissionsInfo
{
    public string Target { get; set; }
    public string Reward { get; set; }
    public string FirstReward { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "target_":
                    Target = reader.ReadString(); break;
                case "reward_":
                    Reward = reader.ReadString(); break;
                case "firstReward_":
                    FirstReward = reader.ReadString(); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for SubMissionsInfo");

            }
        }
    }
}
