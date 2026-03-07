using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class SectionSortListGuid
{
    public uint Guid { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            Guid = key switch
            {
                "guid_" => uint.Parse(reader.ReadString()),
                _ => throw new NotImplementedException($"Property '{key}' not supported for SectionSortListGuid"),
            };
        }
    }
}
