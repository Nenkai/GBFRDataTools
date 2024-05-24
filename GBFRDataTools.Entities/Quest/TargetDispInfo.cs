using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class TargetDispInfo
{
    public string TextHash { get; set; }
    public int Type { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "textHash_":
                    TextHash = reader.ReadString(); break;
                case "type_":
                    Type = int.Parse(reader.ReadString()); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for MultiInfo");
            }
        }
    }
}
