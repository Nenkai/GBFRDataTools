using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.Behavior;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonMultipleShotAction : BehaviorCreateShotAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonMultipleShotAction);

    [JsonPropertyName("howManyShot_")]
    public int HowManyShot { get; set; } = 1;

    public SummonMultipleShotAction()
    {
        IsUseObjId = false;
        ShotObjId = -1;
        IsSetPos = false;
        PartsNo = -1;
        Offset = Vector4.UnitW;
        IsSetRot = false;
        IsOwnRot = false;
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        IsSetScale = false;
        Scale = 1f;
        IsRotateChr = false;
        IsUseBBPos = false;
        IsUseBBRot = false;
        IsTrackShot = false;
    }
}
