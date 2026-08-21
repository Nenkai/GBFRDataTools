using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600PoisonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600PoisonAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; 

    [JsonPropertyName("diffusionAreaRange_")]
    public float DiffusionAreaRange { get; set; } = 2.5f; 

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 6; 

    [JsonPropertyName("disengageRange_")]
    public float DisengageRange { get; set; } = 1f; 

    [JsonPropertyName("dirDeg_")]
    public float DirDeg { get; set; } = 90f; 

    [JsonPropertyName("targetOffset_")]
    public Vector4 TargetOffset { get; set; } = Vector4.UnitW;
}

