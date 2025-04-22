using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Weapon.We2100;

namespace GBFRDataTools.Entities.Parameters;

public class SuperiorWeaponParam : EnemyParameterInfo
{
    [JsonPropertyName("moveAroundParam_")]
    public MoveAroundParam MoveAroundParam_ { get; set; }

    [JsonPropertyName("actionInfoList_")]
    public BindingList<ActionInfo> ActionInfoList { get; set; } = [];

    [JsonPropertyName("actionStates_")]
    public BindingList<int> ActionStates { get; set; } = [];

    public SuperiorWeaponParam()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MoveAroundParam
    {
        [JsonPropertyName("moveSpeedRate_")]
        [Editable(false)]
        public BindingList<float> MoveSpeedRate { get; set; } = [.. Enumerable.Repeat(0, 4).ToList()]; // std::array<float,4> // Offset 0x8

        [JsonPropertyName("jumpHeightY_")]
        public float JumpHeightY { get; set; } // Offset 0x18

        [JsonPropertyName("isMoveSec_")]
        public bool IsMoveSec { get; set; } // Offset 0x1C

        [JsonPropertyName("moveSpeed_")]
        public float MoveSpeed { get; set; } // Offset 0x20

        [JsonPropertyName("addAngleY_")]
        public float AddAngleY { get; set; } // Offset 0x24

        [JsonPropertyName("randomRangeY_")]
        public float RandomRangeY { get; set; } // Offset 0x28

        [JsonPropertyName("ownerDist_")]
        public float OwnerDist { get; set; } // Offset 0x2C

        [JsonPropertyName("isTargetPlayer_")]
        public bool IsTargetPlayer { get; set; } // Offset 0x30

        public MoveAroundParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ActionInfo
    {
        [JsonPropertyName("actions_")]
        public BindingList<int> Actions { get; set; } = []; // Offset 0x8

        public ActionInfo()
        {
        }
    }
}
