using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkOverDriveBeamExpandAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkOverDriveBeamExpandAction);

    [JsonPropertyName("attackSizeXStart_")]
    public float AttackSizeXStart { get; set; } = 1f;

    [JsonPropertyName("attackSizeXMax_")]
    public float AttackSizeXMax { get; set; } = 4f;

    [JsonPropertyName("expnadRate_")]
    public float ExpnadRate { get; set; } = 1f;

    [JsonPropertyName("expandTime_")]
    public float ExpandTime { get; set; } = 5f;

    [JsonPropertyName("isBeamEnd_")]
    public bool IsBeamEnd { get; set; } = false;

    public Em8300AtkOverDriveBeamExpandAction()
    {
        Offset = new Vector4(0f, 0f, 0f, 1f);
        Size = new Vector4(1f, 1f, 1f, 1f);
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        Shape = 0;
        Direction = 0;
        Target = 0;
        OverWriteParamType = 0;
        GlobalType = 0;
        Type = 0;
        Reaction = 0;
        CategoryFlag = 0;
        Element = 0;
        AttackRate = 1f;
        BreakRate = 1f;
        SpArtsRate = 1f;
        HitStopSecond = 0f;
        HitVibrationType = 0;
        LifeSecond = 0f;
        MultiHitIntervalSecond = 0f;
        KnockBackRate = 1f;
        DamageMovementRate = 1f;
        DamageMovementRateY = 1f;
        IsHitOnce = true;
        IsMoveToHitPos = false;
        IsSetAttackerPos = false;
        IsSetAttackerHitList = false;
        IsClearHitList = true;
        MultiHitLimit = 0;
        IsSwept = true;
        AttackClearTime = 0f;
        AppropriStartDist = -1f;
        AppropriEndDist = 0f;
        NotAppropriDistAtkRate = 0f;
        IsTakeOverAppropriDist = false;
        IsAlreadyHitClearEachEntity = false;
        IsHitOnlyHormingTarget = false;
    }
}