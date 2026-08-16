using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkHomingBigPlasmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkHomingBigPlasmaAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 30;

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_mul";

    [JsonPropertyName("shotStartPosOffset_")]
    public Vector4 ShotStartPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotParameterList_")]
    public BindingList<ShotParameter> ShotParameterList { get; set; } = []; // std::vector<Em8400AtkHomingBigPlasmaAction::ShotParameter>

    [JsonPropertyName("attackStartDelaySec_")]
    public float AttackStartDelaySec { get; set; } = 0.5f;

    public class ShotParameter /* Em8400AtkHomingBigPlasmaAction::ShotParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    }
}
