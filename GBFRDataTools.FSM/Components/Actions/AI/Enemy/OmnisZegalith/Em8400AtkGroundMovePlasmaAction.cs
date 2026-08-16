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
public class Em8400AtkGroundMovePlasmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkGroundMovePlasmaAction);

    [JsonPropertyName("groundPlasmaParamList_")]
    public BindingList<GroundPlasmaParameter> GroundPlasmaParamList { get; set; } = []; // std::vector<BT::Em8400AtkGroundMovePlasmaAction::GroundPlasmaParameter>

    [JsonPropertyName("actionEndIntervalSec_")]
    public float ActionEndIntervalSec { get; set; } = 1f;

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "shot_ground_move_plasma";

    [JsonPropertyName("isShowSkillName_")]
    public bool IsShowSkillName { get; set; } = false;

    [JsonPropertyName("startMotionId_")]
    public MotionParameter StartMotionId { get; set; } = new();

    [JsonPropertyName("endMotionId_")]
    public MotionParameter EndMotionId { get; set; } = new();

    public class GroundPlasmaParameter /* Em8400AtkGroundMovePlasmaAction::GroundPlasmaParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20
    
        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; }
    }

    public class MotionParameter /* Em8400AtkGroundMovePlasmaAction::MotionParameter */
    {
        [JsonPropertyName("motId_")]
        public string MotId { get; set; }
    
        [JsonPropertyName("isLoop_")]
        public bool IsLoop { get; set; }
    
        [JsonPropertyName("loopSec_")]
        public float LoopSec { get; set; }
    
        [JsonPropertyName("isSkipSameMotionPlay_")]
        public bool IsSkipSameMotionPlay { get; set; }
    }
}