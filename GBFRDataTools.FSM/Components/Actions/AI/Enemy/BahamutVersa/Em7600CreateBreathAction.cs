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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600CreateBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600CreateBreathAction);

    [JsonPropertyName("className_")]
    public string? ClassName { get; set; } = "Em7600";

    [JsonPropertyName("fsmName_")]
    public string? FsmName { get; set; } = "FireBall";

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f;

    [JsonPropertyName("atkRate_")]
    public float AtkRate { get; set; } = 1f;

    [JsonPropertyName("velocity_")]
    public float Velocity { get; set; } = 1f;

    [JsonPropertyName("shotFrame_")]
    public int ShotFrame { get; set; } = 0;

    [JsonPropertyName("isAimTartget_")]
    public bool IsAimTartget { get; set; } = true;

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0f;

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0f;

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; } = 0f;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;
}
