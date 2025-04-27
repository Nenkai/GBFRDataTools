using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkMagicFinish1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkMagicFinish1Action);

    [JsonPropertyName("isForceNormalMode_")]
    public bool IsForceNormalMode { get; set; } = false; // Offset 0x1E1

    [JsonPropertyName("isForcePowerupMode_")]
    public bool IsForcePowerupMode { get; set; } = false; // Offset 0x1E2

    [JsonPropertyName("shotSettingIndex_")]
    public int ShotSettingIndex { get; set; } = 0; // Offset 0x1E4

    [JsonPropertyName("isTimeStop_")]
    public bool IsTimeStop { get; set; } = true; // Offset 0x1D0

    [JsonPropertyName("timeStopDelay_")]
    public float TimeStopDelay { get; set; } = 2f; // Offset 0x1D4

    [JsonPropertyName("timeStopTime_")]
    public float TimeStopTime { get; set; } = 2.5f; // Offset 0x1D8

    [JsonPropertyName("correctSpeed_")]
    public float CorrectSpeed { get; set; } = 0.15f; // Offset 0x1DC

    public Em7700AtkMagicFinish1Action()
    {
    }
}

