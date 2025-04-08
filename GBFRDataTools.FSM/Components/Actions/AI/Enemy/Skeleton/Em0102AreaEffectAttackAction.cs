using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0102AreaEffectAttackAction : AreaEffectAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0102AreaEffectAttackAction);

    public Em0102AreaEffectAttackAction()
    {
        Offset = Vector4.UnitW;
        Size = Vector4.One;
        DegreeX = 0f;
        DegreeY = 0f;
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
        DeleySecond = 0f;
        IsMultiHit = false;
        IsSwept = false;
    }
}
