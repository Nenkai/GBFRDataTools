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
public class Em8400AtkHomingShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkHomingShotAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotTargetNum_")]
    public int ShotTargetNum { get; set; } = 1;

    [JsonPropertyName("attackSineTimeSec_")]
    public float AttackSineTimeSec { get; set; } = 3.5f;

    [JsonPropertyName("laserMoveDelaySec_")]
    public float LaserMoveDelaySec { get; set; } = 1f;

    [JsonPropertyName("laserSpeed_")]
    public float LaserSpeed { get; set; } = 0.12f;

    [JsonPropertyName("laserAttackSize_")]
    public float LaserAttackSize { get; set; } = 0.1f;

    [JsonPropertyName("laserAttackTimeSec_")]
    public float LaserAttackTimeSec { get; set; } = 6f;

    [JsonPropertyName("laserMaxSpeed_")]
    public float LaserMaxSpeed { get; set; } = 0.3f;

    [JsonPropertyName("laserSpeedMaxDistance_")]
    public float LaserSpeedMaxDistance { get; set; } = 10f;

    [JsonPropertyName("laserSpeedDownDist_")]
    public float LaserSpeedDownDist { get; set; } = 5f;

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_homing";

    [JsonPropertyName("shotStartPosOffset_")]
    public Vector4 ShotStartPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotParameterList_")]
    public BindingList<ShotParameter> ShotParameterList { get; set; } = []; // std::vector<BT::Em8400AtkHomingShotAction::ShotParameter>

    public class ShotParameter /* Em8400AtkHomingShotAction::ShotParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("initEndPosOffset_")]
        public Vector4 InitEndPosOffset { get; set; }
    }
}
