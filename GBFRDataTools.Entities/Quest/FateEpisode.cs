using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class FateEpisode
{
    public bool IsStartEventTown { get; set; }
    public bool IsEndEventTown { get; set; }
    public int TownType { get; set; }
    public bool HasStartEvent { get; set; }
    public bool HasEndEvent { get; set; }
    public bool HasStartTelop { get; set; }
    public bool HasClearTelop { get; set; }
    public int GameCategory { get; set; }
    public string Location { get; set; }
    public TargetDispInfo TargetDispInfo { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "isStartEventTown_":
                    IsStartEventTown = bool.Parse(reader.ReadString()); break;
                case "isEndEventTown_":
                    IsEndEventTown = bool.Parse(reader.ReadString()); break;
                case "townType_":
                    TownType = int.Parse(reader.ReadString()); break;
                case "hasStartEvent_":
                    HasStartEvent = bool.Parse(reader.ReadString()); break;
                case "hasEndEvent_":
                    HasEndEvent = bool.Parse(reader.ReadString()); break;
                case "hasStartTelop_":
                    HasStartTelop = bool.Parse(reader.ReadString()); break;
                case "hasClearTelop_":
                    HasClearTelop = bool.Parse(reader.ReadString()); break;
                case "gameCategory_":
                    GameCategory = int.Parse(reader.ReadString()); break;
                case "location_":
                    Location = reader.ReadString(); break;
                case "targetDispInfo_":
                    TargetDispInfo = new TargetDispInfo();
                    TargetDispInfo.Read(ref reader);
                    break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for FateEpisode");
            }
        }
    }
}
