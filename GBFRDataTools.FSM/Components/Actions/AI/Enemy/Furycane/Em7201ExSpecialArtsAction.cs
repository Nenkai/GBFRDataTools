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
    public BindingList<int> StrongWindType { get; set; } = [.. Enumerable.Repeat(0, 2)]; // Offset 0x558

    [JsonPropertyName("retargetAttackCount_")]
    public int RetargetAttackCount { get; set; } = 1; // Offset 0x560

    [JsonPropertyName("hominggRate_")]
    public float HominggRate { get; set; } = 2f; // Offset 0x564

    [JsonPropertyName("targetAttackHate_")]
    public int TargetAttackHate { get; set; } = 90; // Offset 0x568

    [JsonPropertyName("selfMoveSpd_")]
    public float SelfMoveSpd { get; set; } = 0.015f; // Offset 0x56C

    [JsonPropertyName("wayShotAngle_")]
    public float WayShotAngle { get; set; } = 30f; // Offset 0x570

    [JsonPropertyName("targetMaxCount_")]
    public int TargetMaxCount { get; set; } = 3; // Offset 0x574

    [JsonPropertyName("targetCloseLen_")]
    public float TargetCloseLen { get; set; } = 8f; // Offset 0x578

    [JsonPropertyName("shotWaitTime_")]
    public float ShotWaitTime { get; set; } = 0.4f; // Offset 0x588

    [JsonPropertyName("shotWindWaitTime_")]
    public float ShotWindWaitTime { get; set; } = 0.665f; // Offset 0x58C

    [JsonPropertyName("shotOffset_")]
    public Vector4 ShotOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x590

    [JsonPropertyName("wayOffset_")]
    public Vector4 WayOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x5A0

    [JsonPropertyName("horizonOffset_")]
    public Vector4 HorizonOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x5B0

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x5C0

    [JsonPropertyName("loopMotionId_")]
    public string LoopMotionId { get; set; } // Offset 0x5E0

    [JsonPropertyName("loopMotionId2_")]
    public string LoopMotionId2 { get; set; } // Offset 0x600

    [JsonPropertyName("loopMotionId3_")]
    public string LoopMotionId3 { get; set; } // Offset 0x620

    [JsonPropertyName("showArtsText_")]
    public bool ShowArtsText { get; set; } = true; // Offset 0x640

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } // Offset 0x648

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } // Offset 0x668

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x690

    [JsonPropertyName("galeToOutSideTime_")]
    public float GaleToOutSideTime { get; set; } = 1f; // Offset 0x57C

    [JsonPropertyName("galeToOutSideSpeed_")]
    public float GaleToOutSideSpeed { get; set; } = 5f; // Offset 0x580

    [JsonPropertyName("galeToOutSideRange_")]
    public float GaleToOutSideRange { get; set; } = 10f; // Offset 0x584

    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public StormSetPosInfo()
        {
        }
    }


    public class DependAILevelParam
    {
        [JsonPropertyName("loopNum_")]
        public int LoopNum { get; set; } // Offset 0x8

        [JsonPropertyName("breakPower_")]
        public float BreakPower { get; set; } // Offset 0xC

        [JsonPropertyName("stormSpeed_")]
        public float StormSpeed { get; set; } // Offset 0x10

        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } // Offset 0x14

        [JsonPropertyName("stormLife_")]
        public float StormLife { get; set; } // Offset 0x18

        [JsonPropertyName("isAroundAttack_")]
        public bool IsAroundAttack { get; set; } // Offset 0x1C

        [JsonPropertyName("animMoveRate_")]
        public float AnimMoveRate { get; set; } // Offset 0x20

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; // Offset 0x28

        [JsonPropertyName("stormMax_")]
        public int StormMax { get; set; } // Offset 0x40

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x44

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } // Offset 0x48
    }
}

