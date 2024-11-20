using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotBgLayAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public cVec4 Offset { get; set; }

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("hitType_")]
    public int HitType { get; set; }

    [JsonPropertyName("isHitAttackOff_")]
    public bool IsHitAttackOff { get; set; }

    [JsonPropertyName("isMoveToHitPos_")]
    public bool IsMoveToHitPos { get; set; }

    [JsonPropertyName("isResetRotHitPos_")]
    public bool IsResetRotHitPos { get; set; }
}
