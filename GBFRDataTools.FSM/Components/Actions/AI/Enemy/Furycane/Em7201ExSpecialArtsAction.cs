using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201ExSpecialArtsAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExSpecialArtsAction);

    [JsonPropertyName("strongWindType_")]
    [Editable(false)]
    public BindingList<int> StrongWindType { get; set; } = [.. Enumerable.Repeat(0, 2)]; 

    [JsonPropertyName("retargetAttackCount_")]
    public int RetargetAttackCount { get; set; } = 1; 

    [JsonPropertyName("hominggRate_")]
    public float HominggRate { get; set; } = 2f; 

    [JsonPropertyName("targetAttackHate_")]
    public int TargetAttackHate { get; set; } = 90; 

    [JsonPropertyName("selfMoveSpd_")]
    public float SelfMoveSpd { get; set; } = 0.015f; 

    [JsonPropertyName("wayShotAngle_")]
    public float WayShotAngle { get; set; } = 30f; 

    [JsonPropertyName("targetMaxCount_")]
    public int TargetMaxCount { get; set; } = 3; 

    [JsonPropertyName("targetCloseLen_")]
    public float TargetCloseLen { get; set; } = 8f; 

    [JsonPropertyName("shotWaitTime_")]
    public float ShotWaitTime { get; set; } = 0.4f; 

    [JsonPropertyName("shotWindWaitTime_")]
    public float ShotWindWaitTime { get; set; } = 0.665f; 

    [JsonPropertyName("shotOffset_")]
    public Vector4 ShotOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("wayOffset_")]
    public Vector4 WayOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("horizonOffset_")]
    public Vector4 HorizonOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "7002";

    [JsonPropertyName("loopMotionId_")]
    public string? LoopMotionId { get; set; } = "7006";

    [JsonPropertyName("loopMotionId2_")]
    public string? LoopMotionId2 { get; set; } = "7009";

    [JsonPropertyName("loopMotionId3_")]
    public string? LoopMotionId3 { get; set; } = "7010";

    [JsonPropertyName("showArtsText_")]
    public bool ShowArtsText { get; set; } = true;

    [JsonPropertyName("signStartSe_")]
    public string? SignStartSe { get; set; } = "em7200_atk_magiccircle_sign_start";

    [JsonPropertyName("signEndSe_")]
    public string? SignEndSe { get; set; } = "em7200_atk_magiccircle_sign_end";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("galeToOutSideTime_")]
    public float GaleToOutSideTime { get; set; } = 1f; 

    [JsonPropertyName("galeToOutSideSpeed_")]
    public float GaleToOutSideSpeed { get; set; } = 5f; 

    [JsonPropertyName("galeToOutSideRange_")]
    public float GaleToOutSideRange { get; set; } = 10f; 

    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 

        public StormSetPosInfo()
        {
        }
    }


    public class DependAILevelParam
    {
        [JsonPropertyName("loopNum_")]
        public int LoopNum { get; set; } 

        [JsonPropertyName("breakPower_")]
        public float BreakPower { get; set; } 

        [JsonPropertyName("stormSpeed_")]
        public float StormSpeed { get; set; } 

        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } 

        [JsonPropertyName("stormLife_")]
        public float StormLife { get; set; } 

        [JsonPropertyName("isAroundAttack_")]
        public bool IsAroundAttack { get; set; } 

        [JsonPropertyName("animMoveRate_")]
        public float AnimMoveRate { get; set; } 

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; 

        [JsonPropertyName("stormMax_")]
        public int StormMax { get; set; } 

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } 
    }
}

