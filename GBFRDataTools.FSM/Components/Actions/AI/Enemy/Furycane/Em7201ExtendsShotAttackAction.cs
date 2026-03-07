using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201ExtendsShotAttackAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExtendsShotAttackAction);

    [JsonPropertyName("dependMove_")]
    public bool DependMove { get; set; } = false;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.UnitW;

    public Em7201ExtendsShotAttackAction()
    {
        Guid = 0;
        ParentGuid = 0xFFFFFFFF;
        Offset = Vector4.UnitW;
        Size = Vector4.One;
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        Shape = 0;
        Direction = 0;
        Target = 0;
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
        IsSwept = false;
        AttackClearTime = 0f;
        AppropriStartDist = -1f;
        AppropriEndDist = 0f;
        NotAppropriDistAtkRate = 0f;
        IsTakeOverAppropriDist = false;
        IsAlreadyHitClearEachEntity = false;
        IsHitOnlyHormingTarget = false;
    }
}
