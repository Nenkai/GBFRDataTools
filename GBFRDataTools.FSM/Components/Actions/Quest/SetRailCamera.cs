using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetRailCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRailCamera);

    [JsonPropertyName("railObjectId_")]
    public ulong RailObjectId { get; set; }

    [JsonPropertyName("railRootId_")]
    public ulong RailRootId { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("maxSpeedRate_")]
    public float MaxSpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("enableCam_")]
    public bool EnableCam { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
