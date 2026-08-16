using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100TwoComboShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100TwoComboShotAction);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "2502";

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "two_combo_delay_shot";

    [JsonPropertyName("followArrowShotFsmName_")]
    public string FollowArrowShotFsmName { get; set; } = "two_combo_delay_option_shot";

    [JsonPropertyName("firstShotPosParamList_")]
    public BindingList<ShotSettingParameter> FirstShotPosParamList { get; set; } = []; // std::vector<BT::Em8100TwoComboShotAction::ShotSettingParameter>

    [JsonPropertyName("secondShotPosParamList_")]
    public BindingList<ShotSettingParameter> SecondShotPosParamList { get; set; } = []; // std::vector<BT::Em8100TwoComboShotAction::ShotSettingParameter>

    [JsonPropertyName("motionHeightMoveRate_")]
    public float MotionHeightMoveRate { get; set; } = 1f;

    public class ShotSettingParameter /* Em8100TwoComboShotAction::ShotSettingParameter */
    {
        [JsonPropertyName("maxRotX_")]
        public float MaxRotX { get; set; }
    
        [JsonPropertyName("minRotX_")]
        public float MinRotX { get; set; }
    
        [JsonPropertyName("targetJointNo_")]
        public int TargetJointNo { get; set; }

        [JsonPropertyName("posList_")]
        public BindingList<ShotPosParameter> PosList { get; set; } = [];
    }

    public class ShotPosParameter /* Em8100TwoComboShotAction::ShotPosParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("isFollowArrow_")]
        public bool IsFollowArrow { get; set; }
    }
}