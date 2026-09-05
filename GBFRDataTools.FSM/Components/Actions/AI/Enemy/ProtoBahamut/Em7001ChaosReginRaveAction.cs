using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7001ChaosReginRaveAction : Em7001SummonCoreBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ChaosReginRaveAction);

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 1f;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 3f;

    [JsonPropertyName("waitStopTime_")]
    public float WaitStopTime { get; set; } = 1f;

    [JsonPropertyName("waitSlowTime_")]
    public float WaitSlowTime { get; set; } = 1f;

    [JsonPropertyName("attackWaitTime_")]
    public float AttackWaitTime { get; set; } = 1f;

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 5f;

    [JsonPropertyName("chargeStartRotSpeed_")]
    public float ChargeStartRotSpeed { get; set; } = 0.23f;

    [JsonPropertyName("chargeRotSpeed_")]
    public float ChargeRotSpeed { get; set; } = 0.23f;

    [JsonPropertyName("shotStartRotSpeed_")]
    public float ShotStartRotSpeed { get; set; } = 0.23f;

    [JsonPropertyName("shotLoopRotSpeed_")]
    public float ShotLoopRotSpeed { get; set; } = 0.1f;

    [JsonPropertyName("maxAngle_")]
    public float MaxAngle { get; set; } = 0.7f;

    [JsonPropertyName("angleRateValue_")]
    public float AngleRateValue { get; set; } = 1.1f;

    [JsonPropertyName("blendMaxAngleRate_")]
    public float BlendMaxAngleRate { get; set; } = 0.88f;

    [JsonPropertyName("createPos_")]
    public Vector4 CreatePos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("rightBlendRate_")]
    public float RightBlendRate { get; set; } = 0.9f;

    [JsonPropertyName("isAttribute_")]
    public bool IsAttribute { get; set; } = false;

    [JsonPropertyName("homingPhase_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public float HomingPhase { get; set; }

    [JsonPropertyName("decelerationPhase_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public float DecelerationPhase { get; set; }

    [JsonPropertyName("shotName_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public string? ShotName { get; set; }

    [JsonPropertyName("attackAngle_")]
    public float AttackAngle { get; set; } = 0.5f;

    [JsonPropertyName("aiMoveAngle_")]
    public float AiMoveAngle { get; set; } = 0.5f;

    [JsonPropertyName("resetAlreadyHitTime_")]
    public float ResetAlreadyHitTime { get; set; } = 0.5f;

    [JsonPropertyName("vfxDelayKillFrame_")]
    public int VfxDelayKillFrame { get; set; } = 1;

    public Em7001ChaosReginRaveAction()
    {
        AttributeType = 1;
        Side = 0;
        Phase = 0;
    }
}
