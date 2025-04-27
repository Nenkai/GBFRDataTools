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

public class Em7700AtkMagicFinish2Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkMagicFinish2Action);

    [JsonPropertyName("isForceNormalMode_")]
    public bool IsForceNormalMode { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isForcePowerupMode_")]
    public bool IsForcePowerupMode { get; set; } = false; // Offset 0x71

    [JsonPropertyName("isTimeStop_")]
    public bool IsTimeStop { get; set; } = true; // Offset 0x72

    [JsonPropertyName("timeStopDelay_")]
    public float TimeStopDelay { get; set; } = 2f; // Offset 0x74

    [JsonPropertyName("timeStopDelayPowerup_")]
    public float TimeStopDelayPowerup { get; set; } = 10f; // Offset 0x78

    [JsonPropertyName("timeStopTime_")]
    public float TimeStopTime { get; set; } = 2.5f; // Offset 0x7C

    [JsonPropertyName("correctSpeed_")]
    public float CorrectSpeed { get; set; } = 1f; // Offset 0x80

    [JsonPropertyName("correctSpeedPowerup_")]
    public float CorrectSpeedPowerup { get; set; } = 1f; // Offset 0x84

    public Em7700AtkMagicFinish2Action()
    {
    }
}


