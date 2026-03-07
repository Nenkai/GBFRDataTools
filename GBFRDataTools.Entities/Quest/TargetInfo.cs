using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

/// <summary>
/// stage::quest::TargetInfo
/// </summary>
public class TargetInfo
{
    public string Label { get; set; }
    public string TextLabel { get; set; }
    public int Type { get; set; }
    public uint Id { get; set; }
    public float Count { get; set; }
    public bool CanFail { get; set; }
    public bool IsDisplay { get; set; }
    public int IdIndex { get; set; }
    public uint UdsId { get; set; }

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
                case "id_":
                    Id = uint.Parse(reader.ReadString()); break;
                case "count_":
                    Count = float.Parse(reader.ReadString()); break;
                case "canFail_":
                    CanFail = bool.Parse(reader.ReadString()); break;
                case "isDisplay_":
                    IsDisplay = bool.Parse(reader.ReadString()); break;
                case "idIndex_":
                    IdIndex = int.Parse(reader.ReadString()); break;
                case "udsId_":
                    UdsId = uint.Parse(reader.ReadString()); break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for TargetInfo");

            }
        }
    }
}
