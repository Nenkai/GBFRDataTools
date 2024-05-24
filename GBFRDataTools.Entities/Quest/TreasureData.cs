using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;


public class TreasureData
{
    public string Data { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "data_":
                    Data = reader.ReadString(); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for TreasureData");

            }
        }
    }
}
