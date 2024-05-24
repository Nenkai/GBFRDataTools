using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Quest;

public class ChallengeInfo
{
    public List<ulong> UUIDHashes { get; set; } = [];
    public List<int> PhaseNumbers { get; set; } = [];
    public List<int> RotOffsets { get; set; } = [];
    public List<bool> IsSpawn { get; set; } = [];
    public bool IsConsecutive { get; set; }

    public bool IsChapterSelectPartyKeep { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "isConsecutive_":
                    IsConsecutive = bool.Parse(reader.ReadString()); break;

                default:
                    if (key.StartsWith("uuidHashs_"))
                        UUIDHashes.Add(ulong.Parse(reader.ReadString()));
                    else if (key.StartsWith("phaseNos_"))
                        PhaseNumbers.Add(int.Parse(reader.ReadString()));
                    else if (key.StartsWith("rotOffset"))
                        RotOffsets.Add(int.Parse(reader.ReadString()));
                    else if (key.StartsWith("isSpawn_"))
                        IsSpawn.Add(bool.Parse(reader.ReadString()));
                    else
                        throw new NotImplementedException($"Property '{key}' not supported for ChallengeInfo");
                    break;
            }
        }
    }
}
