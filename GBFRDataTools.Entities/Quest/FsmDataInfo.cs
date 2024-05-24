using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

/// <summary>
/// stage::quest::FsmDataInfo
/// </summary>
public class FsmDataInfo
{
    public string Name { get; set; }
    public ulong Hash { get; set; }
    public int Suffix { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "name_":
                    Name = reader.ReadString(); break;
                case "hash_":
                    Hash = ulong.Parse(reader.ReadString()); break;
                case "suffix_":
                    Suffix = int.Parse(reader.ReadString()); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for FsmDataInfo");
            }
        }
    }
}
