using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Whitewyrm;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So3e00RotatingBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So3e00RotatingBreathAction);

    [JsonPropertyName("signScaleY_")]
    public float SignScaleY { get; set; } = 1f;

    [JsonPropertyName("signSize_")]
    public Vector4 SignSize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("signPosOffset_")]
    public Vector4 SignPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("signTurnAngle_")]
    public float SignTurnAngle { get; set; } = 86f;

    [JsonPropertyName("breathStartedSignTurnAngle_")]
    public float BreathStartedSignTurnAngle { get; set; } = 86f;

    [JsonPropertyName("signTurnLimit_")]
    public float SignTurnLimit { get; set; } = 65f;

    [JsonPropertyName("breathTurnRate_")]
    public float BreathTurnRate { get; set; } = 0.1f;

    [JsonPropertyName("breathTurnInterTime_")]
    public float BreathTurnInterTime { get; set; } = 0.2f;

    [JsonPropertyName("breathLength_")]
    public float BreathLength { get; set; } = 40f;

    [JsonPropertyName("breathDirOffset_")]
    public float BreathDirOffset { get; set; } = 0f;

    [JsonPropertyName("breathOffsetZ_")]
    public float BreathOffsetZ { get; set; } = 2f;

    [JsonPropertyName("breathAttackRadius_")]
    public float BreathAttackRadius { get; set; } = 3f;

    [JsonPropertyName("breathAttackRate_")]
    public float BreathAttackRate { get; set; } = 1f;

    [JsonPropertyName("breathBreakRate_")]
    public float BreathBreakRate { get; set; } = 1f;

    [JsonPropertyName("breathAttackOffsetZ_")]
    public float BreathAttackOffsetZ { get; set; } = 0f;

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; } = 1f;

    [JsonPropertyName("blendInterRate_")]
    public float BlendInterRate { get; set; } = 1f;

    [JsonPropertyName("autoTurnTime_")]
    public float AutoTurnTime { get; set; } = 0.5f;
}
