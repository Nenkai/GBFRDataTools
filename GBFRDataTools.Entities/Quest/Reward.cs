using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class RewardInfo
{
    public string First { get; set; }
    public string Every { get; set; }

    // rankRewards_[{0}]
    public List<string> RankRewards { get; set; } = [];

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "first_":
                    First = reader.ReadString(); break;
                case "every_":
                    Every = reader.ReadString(); break;

                default:
                    if (key.StartsWith("rankRewards_"))
                    {
                        if (RankRewards.Count >= 7)
                            throw new InvalidDataException("Reward node has more than 6 rankRewards_ keys.");

                        RankRewards.Add(reader.ReadString());
                    }
                    else
                        throw new NotImplementedException($"Property '{key}' not supported for Reward");
                    break;
            }
        }
    }
}
