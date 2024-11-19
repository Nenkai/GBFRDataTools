using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcMovePassAction : BehaviorJumpAction
{
    [JsonPropertyName("params_")]
    public BindingList<PassParam> Params { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("isStartCurPos_")]
    public bool IsStartCurPos { get; set; }

    [JsonPropertyName("startMotionName_")]
    public string StartMotionName { get; set; }

    [JsonPropertyName("endMotionName_")]
    public string EndMotionName { get; set; }

    [JsonPropertyName("jumpRizeMotionName_")]
    public string JumpRizeMotionName { get; set; }

    [JsonPropertyName("jumpEndMotionName_")]
    public string JumpEndMotionName { get; set; }

    [JsonPropertyName("secondFromLandToMove_")]
    public float SecondFromLandToMove { get; set; }

    [JsonPropertyName("adjustAnimation_")]
    public bool AdjustAnimation { get; set; }

    [JsonPropertyName("waitEndMotion_")]
    public bool WaitEndMotion { get; set; }

    public class PassParam // BT::NpcMovePassAction::PassParam
    {
        [JsonPropertyName("pos_")]
        public cVec4 Pos { get; set; }

        [JsonPropertyName("length_")]
        public float Length { get; set; }

        [JsonPropertyName("useNavMesh_")]
        public bool UseNavMesh { get; set; }
    }
}
