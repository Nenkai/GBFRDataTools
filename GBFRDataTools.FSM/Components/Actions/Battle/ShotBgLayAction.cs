using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotBgLayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotBgLayAction);

    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0.0f;

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0.0f;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 0.0f;

    [JsonPropertyName("hitType_")]
    public int HitType { get; set; } = 0;

    [JsonPropertyName("isHitAttackOff_")]
    public bool IsHitAttackOff { get; set; } = true;

    [JsonPropertyName("isMoveToHitPos_")]
    public bool IsMoveToHitPos { get; set; } = false;

    [JsonPropertyName("isResetRotHitPos_")]
    public bool IsResetRotHitPos { get; set; } = false;
}
