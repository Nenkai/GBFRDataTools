using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100SlashComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100SlashComboAction);

    [JsonPropertyName("atkCount_")]
    public int AtkCount { get; set; } = 3;

    [JsonPropertyName("motionIdNameFirst_")]
    public string? MotionIdNameFirst { get; set; } = "1100";

    [JsonPropertyName("motionIdNameSecond_")]
    public string? MotionIdNameSecond { get; set; } = "1101";

    [JsonPropertyName("motionIdNameThird_")]
    public string? MotionIdNameThird { get; set; } = "1102";

    [JsonPropertyName("rotRate_")]
    public float RotRate { get; set; } = 0.2f; 
}
