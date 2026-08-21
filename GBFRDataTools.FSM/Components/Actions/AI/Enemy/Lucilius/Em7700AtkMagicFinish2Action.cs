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
    public bool IsForceNormalMode { get; set; } = false; 

    [JsonPropertyName("isForcePowerupMode_")]
    public bool IsForcePowerupMode { get; set; } = false; 

    [JsonPropertyName("isTimeStop_")]
    public bool IsTimeStop { get; set; } = true; 

    [JsonPropertyName("timeStopDelay_")]
    public float TimeStopDelay { get; set; } = 2f; 

    [JsonPropertyName("timeStopDelayPowerup_")]
    public float TimeStopDelayPowerup { get; set; } = 10f; 

    [JsonPropertyName("timeStopTime_")]
    public float TimeStopTime { get; set; } = 2.5f; 

    [JsonPropertyName("correctSpeed_")]
    public float CorrectSpeed { get; set; } = 1f; 

    [JsonPropertyName("correctSpeedPowerup_")]
    public float CorrectSpeedPowerup { get; set; } = 1f; 
}