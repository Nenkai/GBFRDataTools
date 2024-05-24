using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Quest;

public class Condition
{
    public int Type { get; set; }
    public uint Id { get; set; }
    public int Count { get; set; }

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
                case "id_":
                    Id = uint.Parse(reader.ReadString()); break;
                case "count_":
                    Count = int.Parse(reader.ReadString()); break;
                default:
                    throw new NotImplementedException($"Property '{key}' not supported for Condition");
            }
        }
    }
}
