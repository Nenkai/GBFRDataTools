using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

/// <summary>
/// stage::quest::SpecialRegulationInfo
/// </summary>
public class SpecialRegulationInfo
{
    public string Label { get; set; }
    public string TextLabel { get; set; }
    public int Type { get; set; }
    public ulong Value0 { get; set; }
    public ulong Value1 { get; set; }
    public ulong Value2 { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "label_":
                    Label = reader.ReadString(); break;
                case "textLabel_":
                    TextLabel = reader.ReadString(); break;
                case "type_":
                    Type = int.Parse(reader.ReadString()); break;
                case "value0_":
                    Value0 = ulong.Parse(reader.ReadString()); break;
                case "value1_":
                    Value1 = ulong.Parse(reader.ReadString()); break;
                case "value2_":
                    Value2 = ulong.Parse(reader.ReadString()); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for SpecialRegulationInfo");

            }
        }
    }
}
