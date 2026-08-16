using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmGroupEscapeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGroupEscapeAction);

    [JsonPropertyName("isBackJump_")]
    public bool IsBackJump { get; set; } = false;

    [JsonPropertyName("isSuspendByActionEnd_")]
    public bool IsSuspendByActionEnd { get; set; } = false;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }

    [JsonPropertyName("escapePosList_")]
    public BindingList<EmPositionParam> EscapePosList { get; set; } = []; // std::vector<EmPositionParam>

    [JsonPropertyName("maxJumpHeight_")]
    public float MaxJumpHeight { get; set; } = 10f;

    [JsonPropertyName("isLandingEndTimeSet_")]
    public bool IsLandingEndTimeSet { get; set; } = false;

    [JsonPropertyName("LandingEndTimeSec_")]
    public float LandingEndTimeSec { get; set; } = 1f;

    [JsonPropertyName("turnTargetPos_")]
    public Vector4 TurnTargetPos { get; set; } = new Vector4(-270.98f, 88.41f, -51.95f, 1f);
}
