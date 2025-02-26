using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcMovePassAction : ActionComponent
{
    [JsonPropertyName("params_")]
    public BindingList<PassParam> Params { get; set; } = [new PassParam()];

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 1.0f;

    [JsonPropertyName("isStartCurPos_")]
    public bool IsStartCurPos { get; set; } = false;

    [JsonPropertyName("startMotionName_")]
    public string StartMotionName { get; set; } = "0000";

    [JsonPropertyName("endMotionName_")]
    public string EndMotionName { get; set; } = "0000";

    [JsonPropertyName("jumpRizeMotionName_")]
    public string JumpRizeMotionName { get; set; } = "0000";

    [JsonPropertyName("jumpEndMotionName_")]
    public string JumpEndMotionName { get; set; } = "0000";

    [JsonPropertyName("secondFromLandToMove_")]
    public float SecondFromLandToMove { get; set; } = 1.0f;

    [JsonPropertyName("adjustAnimation_")]
    public bool AdjustAnimation { get; set; } = false;

    [JsonPropertyName("waitEndMotion_")]
    public bool WaitEndMotion { get; set; } = false;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PassParam // BT::NpcMovePassAction::PassParam
    {
        [JsonPropertyName("pos_")]
        public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("length_")]
        public float Length { get; set; } = 0.0f;

        [JsonPropertyName("useNavMesh_")]
        public bool UseNavMesh { get; set; } = false;
    }
}
