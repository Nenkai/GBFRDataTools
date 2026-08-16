using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000VortexAreaShotAttackAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000VortexAreaShotAttackAction);

    public Em8000VortexAreaShotAttackAction()
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