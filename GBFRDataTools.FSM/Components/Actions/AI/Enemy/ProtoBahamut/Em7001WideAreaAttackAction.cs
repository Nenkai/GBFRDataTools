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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001WideAreaAttackAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001WideAreaAttackAction);

    public Em7001WideAreaAttackAction()
    {
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
