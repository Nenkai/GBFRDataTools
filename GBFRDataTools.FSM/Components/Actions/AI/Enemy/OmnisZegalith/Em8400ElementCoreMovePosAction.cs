using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreMovePosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreMovePosAction);

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f;

    [JsonPropertyName("moveTargetPos_")]
    public Vector4 MoveTargetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("moveRadius_")]
    public float MoveRadius { get; set; } = 0f;

    [JsonPropertyName("isRadiusPos_")]
    public bool IsRadiusPos { get; set; } = false;

    [JsonPropertyName("isRelativePos_")]
    public bool IsRelativePos { get; set; } = false;

    [JsonPropertyName("isTurnTargetPos_")]
    public bool IsTurnTargetPos { get; set; } = false;

    [JsonPropertyName("turnTargetPos_")]
    public Vector4 TurnTargetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}
