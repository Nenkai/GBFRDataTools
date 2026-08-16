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
public class Em8100ShotComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ShotComboAction);

    [JsonPropertyName("comboParameterList_")]
    public BindingList<ShotComboActionParamater> ComboParameterList { get; set; } = []; // std::vector<BT::Em8100ShotComboAction::ShotComboActionParamater>

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.05f;

    [JsonPropertyName("backMoveSpeed_")]
    public float BackMoveSpeed { get; set; } = 0f;

    [JsonPropertyName("setOffsetYHeight_")]
    public float SetOffsetYHeight { get; set; } = -1f;

    public class ShotComboActionParamater /* Em8100ShotComboAction::ShotComboActionParamater */
    {
        [JsonPropertyName("motionId_")]
        public string MotionId { get; set; }

        [JsonPropertyName("motionIdByMoveLeft_")]
        public string MotionIdByMoveLeft { get; set; } = "-";

        [JsonPropertyName("motionIdByMoveRight_")]
        public string MotionIdByMoveRight { get; set; } = "-";
    
        [JsonPropertyName("isSingleMotionPlay_")]
        public bool IsSingleMotionPlay { get; set; }
    
        [JsonPropertyName("isNotUseMotionPlay_")]
        public bool IsNotUseMotionPlay { get; set; }
    
        [JsonPropertyName("isUseSideMoveMotion_")]
        public bool IsUseSideMoveMotion { get; set; }
    
        [JsonPropertyName("motionLoopFrame_")]
        public int MotionLoopFrame { get; set; }
    
        [JsonPropertyName("attackSignFrame_")]
        public int AttackSignFrame { get; set; }
    
        [JsonPropertyName("comboEndFrame_")]
        public int ComboEndFrame { get; set; }

        [JsonPropertyName("maxRotX_")]
        public float MaxRotX { get; set; } = 60.0f;

        [JsonPropertyName("minRotX_")]
        public float MinRotX { get; set; } = -60.0f;
    
        [JsonPropertyName("shotFsmName_")]
        public string ShotFsmName { get; set; }
    
        [JsonPropertyName("followArrowShotFsmName_")]
        public string FollowArrowShotFsmName { get; set; }

        [JsonPropertyName("shotParameterList_")]
        public BindingList<ShotParamater> ShotParameterList { get; set; } = []; // std::vector<BT::Em8100ShotComboAction::ShotParamater>
    }

    public class ShotParamater /* Em8100ShotComboAction::ShotParamater */
    {
        [JsonPropertyName("isFollowArrow_")]
        public bool IsFollowArrow { get; set; }
    
        [JsonPropertyName("shotPosOffset_")]
        public Vector4 ShotPosOffset { get; set; }
    }
}