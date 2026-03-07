using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

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

public class Em7200ContinuousWhirlWindAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200ContinuousWhirlWindAction);

    [JsonPropertyName("stormNum_")]
    public int StormNum { get; set; } = 4; // Offset 0x56C

    [JsonPropertyName("causeWhirlNumAtOneTime_")]
    public int CauseWhirlNumAtOneTime { get; set; } = 4; // Offset 0x570

    [JsonPropertyName("causeWhirlNum_")]
    public int CauseWhirlNum { get; set; } = 5; // Offset 0x574

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; // Offset 0x578

    [JsonPropertyName("stormMoveSpeed_")]
    public float StormMoveSpeed { get; set; } = 2f; // Offset 0x57C

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 4f; // Offset 0x580

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; // Offset 0x584

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 15f; // Offset 0x588

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 4.333f; // Offset 0x58C

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } // Offset 0x590

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } // Offset 0x5B0

    [JsonPropertyName("jumpSignTime_")]
    public float JumpSignTime { get; set; } = 2f; // Offset 0x5D0

    [JsonPropertyName("selfGaleAddSpd_")]
    public float SelfGaleAddSpd { get; set; } = 4f; // Offset 0x5D4

    [JsonPropertyName("selfGaleDist_")]
    public float SelfGaleDist { get; set; } = 40f; // Offset 0x5D8

    [JsonPropertyName("selfGaleCustom_")]
    public int SelfGaleCustom { get; set; } = 2; // Offset 0x5DC

    [JsonPropertyName("causeWindIntervalTime_")]
    public float CauseWindIntervalTime { get; set; } = 2f; // Offset 0x5E0

    [JsonPropertyName("whirlWindMoveSpd_")]
    public float WhirlWindMoveSpd { get; set; } = 16f; // Offset 0x5E4

    [JsonPropertyName("whirlWindAmplitude_")]
    public float WhirlWindAmplitude { get; set; } = 1.45f; // Offset 0x5E8

    [JsonPropertyName("whirlWindPeriod_")]
    public float WhirlWindPeriod { get; set; } = 0.95f; // Offset 0x5EC

    [JsonPropertyName("motionIdReady_")]
    public string MotionIdReady { get; set; } // Offset 0x5F8

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } // Offset 0x618

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } // Offset 0x638

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } // Offset 0x658

    [JsonPropertyName("stormSetPositions_")]
    [Editable(false)]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)]; // Offset 0x750

    [JsonPropertyName("whirlWindInfo_")]
    [Editable(false)]
    public BindingList<WhirlWindInfo> WhirlWindInfo_ { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; // Offset 0x890

    [JsonPropertyName("whirlRotY_")]
    [Editable(false)]
    public BindingList<float> WhirlRotY { get; set; } = [.. Enumerable.Repeat(0, 5)]; // Offset 0x950

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; // Offset 0x964

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; // Offset 0x968

    [JsonPropertyName("useNihiraParams_")]
    public bool UseNihiraParams { get; set; } = false; // Offset 0x678

    [JsonPropertyName("causeWhirlNumAtOneTimeNihira_")]
    public int CauseWhirlNumAtOneTimeNihira { get; set; } = 4; // Offset 0x67C

    [JsonPropertyName("causeWindIntervalTimeNihira_")]
    public float CauseWindIntervalTimeNihira { get; set; } = 2f; // Offset 0x680

    [JsonPropertyName("whirlWindMoveSpdNihira_")]
    public float WhirlWindMoveSpdNihira { get; set; } = 16f; // Offset 0x684

    [JsonPropertyName("whirlWindAmplitudeNihira_")]
    public float WhirlWindAmplitudeNihira { get; set; } = 1.45f; // Offset 0x688

    [JsonPropertyName("whirlWindPeriodNihira_")]
    public float WhirlWindPeriodNihira { get; set; } = 0.95f; // Offset 0x68C

    [JsonPropertyName("whirlWindInfoNihira_")]
    [Editable(false)]
    public BindingList<WhirlWindInfo> WhirlWindInfoNihira { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; // Offset 0x690

    public Em7200ContinuousWhirlWindAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public StormSetPosInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } // Offset 0x10

        public WhirlWindInfo()
        {
        }
    }
}
