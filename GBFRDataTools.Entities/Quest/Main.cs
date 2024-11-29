using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Quest;

public class MainInfo
{
    public int Type { get; set; }
    public List<int> RecommendedCombatPower { get; set; } = []; // max 4 elem
    public bool IsChapterSelectPartyKeep { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "type_":
                    Type = int.Parse(reader.ReadString()); break;
                case "isChapterSelectPartyKeep_":
                    IsChapterSelectPartyKeep = bool.Parse(reader.ReadString()); break;

                default:
                    if (key.StartsWith("rcommendedCombatPower_"))
                        RecommendedCombatPower.Add(int.Parse(reader.ReadString()));
                    else
                        throw new NotImplementedException($"Property '{key}' not supported for MainInfo");
                    break;
            }
        }
    }
}
