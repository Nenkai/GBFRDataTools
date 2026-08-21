using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2104StepThrowSwordAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104StepThrowSwordAction);

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 60f; 

    [JsonPropertyName("scaleSec_")]
    public float ScaleSec { get; set; } = 0.25f; 

    [JsonPropertyName("offsetCheckMoveScale_")]
    public float OffsetCheckMoveScale { get; set; } = 0.15f; 

    [JsonPropertyName("swordScale_")]
    public float SwordScale { get; set; } = 2.5f; 

    [JsonPropertyName("startDistance_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float StartDistance { get; set; }

    [JsonPropertyName("throwDistance_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float ThrowDistance { get; set; }
}