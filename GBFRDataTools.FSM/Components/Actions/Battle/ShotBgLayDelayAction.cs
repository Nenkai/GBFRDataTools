using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotBgLayDelayAction : ShotBgLayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotBgLayDelayAction);

    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; } = 0f;

    public ShotBgLayDelayAction()
    {
        Offset = Vector4.UnitW;
        DegreeX = 0f;
        DegreeY = 0f;
        Radius = 0f;
        HitType = 4;
        IsHitAttackOff = true;
        IsMoveToHitPos = false;
        IsResetRotHitPos = false;
    }
}
