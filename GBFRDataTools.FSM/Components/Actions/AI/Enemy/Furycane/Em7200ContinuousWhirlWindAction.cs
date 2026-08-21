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
    public int StormNum { get; set; } = 4; 

    [JsonPropertyName("causeWhirlNumAtOneTime_")]
    public int CauseWhirlNumAtOneTime { get; set; } = 4; 

    [JsonPropertyName("causeWhirlNum_")]
    public int CauseWhirlNum { get; set; } = 5; 

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("stormMoveSpeed_")]
    public float StormMoveSpeed { get; set; } = 2f; 

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 4f; 

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; 

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 15f; 

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 4.333f;

    [JsonPropertyName("signStartSe_")]
    public string? SignStartSe { get; set; } = "em7200_atk_magiccircle_sign_start";

    [JsonPropertyName("signEndSe_")]
    public string? SignEndSe { get; set; } = "em7200_atk_magiccircle_sign_end";

    [JsonPropertyName("jumpSignTime_")]
    public float JumpSignTime { get; set; } = 2f; 

    [JsonPropertyName("selfGaleAddSpd_")]
    public float SelfGaleAddSpd { get; set; } = 4f; 

    [JsonPropertyName("selfGaleDist_")]
    public float SelfGaleDist { get; set; } = 40f; 

    [JsonPropertyName("selfGaleCustom_")]
    public int SelfGaleCustom { get; set; } = 2; 

    [JsonPropertyName("causeWindIntervalTime_")]
    public float CauseWindIntervalTime { get; set; } = 2f; 

    [JsonPropertyName("whirlWindMoveSpd_")]
    public float WhirlWindMoveSpd { get; set; } = 16f; 

    [JsonPropertyName("whirlWindAmplitude_")]
    public float WhirlWindAmplitude { get; set; } = 1.45f; 

    [JsonPropertyName("whirlWindPeriod_")]
    public float WhirlWindPeriod { get; set; } = 0.95f;

    [JsonPropertyName("motionIdReady_")]
    public string? MotionIdReady { get; set; } = "1a10";

    [JsonPropertyName("motionIdStart_")]
    public string? MotionIdStart { get; set; } = "1a11";

    [JsonPropertyName("motionIdLoop_")]
    public string? MotionIdLoop { get; set; } = "1a12";

    [JsonPropertyName("motionIdEnd_")]
    public string? MotionIdEnd { get; set; } = "1a13";

    [JsonPropertyName("stormSetPositions_")]
    [Editable(false)]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)]; 

    [JsonPropertyName("whirlWindInfo_")]
    [Editable(false)]
    public BindingList<WhirlWindInfo> WhirlWindInfo_ { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; 

    [JsonPropertyName("whirlRotY_")]
    [Editable(false)]
    public BindingList<float> WhirlRotY { get; set; } = [.. Enumerable.Repeat(0, 5)]; 

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; 

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; 

    [JsonPropertyName("useNihiraParams_")]
    public bool UseNihiraParams { get; set; } = false; 

    [JsonPropertyName("causeWhirlNumAtOneTimeNihira_")]
    public int CauseWhirlNumAtOneTimeNihira { get; set; } = 4; 

    [JsonPropertyName("causeWindIntervalTimeNihira_")]
    public float CauseWindIntervalTimeNihira { get; set; } = 2f; 

    [JsonPropertyName("whirlWindMoveSpdNihira_")]
    public float WhirlWindMoveSpdNihira { get; set; } = 16f; 

    [JsonPropertyName("whirlWindAmplitudeNihira_")]
    public float WhirlWindAmplitudeNihira { get; set; } = 1.45f; 

    [JsonPropertyName("whirlWindPeriodNihira_")]
    public float WhirlWindPeriodNihira { get; set; } = 0.95f; 

    [JsonPropertyName("whirlWindInfoNihira_")]
    [Editable(false)]
    public BindingList<WhirlWindInfo> WhirlWindInfoNihira { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } 
    }
}
