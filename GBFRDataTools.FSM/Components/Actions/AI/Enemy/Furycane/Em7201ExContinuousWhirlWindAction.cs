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

public class Em7201ExContinuousWhirlWindAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExContinuousWhirlWindAction);

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("stormMoveSpeed_")]
    public float StormMoveSpeed { get; set; } = 0.005f; 

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 5f; 

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; 

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 5f;

    [JsonPropertyName("motionIdStart_")]
    public string? MotionIdStart { get; set; } = "11a0";

    [JsonPropertyName("motionIdLoop_")]
    public string? MotionIdLoop { get; set; } = "11a1";

    [JsonPropertyName("motionIdEnd_")]
    public string? MotionIdEnd { get; set; } = "11a2";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("aiLevelParamArrayNihira_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArrayNihira { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; 

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; 

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("eventFSMId_")]
    public string? EventFSMId { get; set; } = "7st_od_interrupt";

    [JsonPropertyName("eventCameraOffset_")]
    public Vector4 EventCameraOffset { get; set; } = new Vector4(0f, 6f, 12f, 1f); 

    [JsonPropertyName("eventCameraPanRate_")]
    public float EventCameraPanRate { get; set; } = 0.3f; 

    [JsonPropertyName("eventCameraMoveRate_")]
    public float EventCameraMoveRate { get; set; } = 0.02f; 

    [JsonPropertyName("eventCameraDegreeY_")]
    public float EventCameraDegreeY { get; set; } = 30f; 

    [JsonPropertyName("eventExOdUseCount_")]
    public int EventExOdUseCount { get; set; } = 2; 

    [JsonPropertyName("eventIdoDistance_")]
    public float EventIdoDistance { get; set; } = 9f; 

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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("useNihiraParam_")]
        public bool UseNihiraParam { get; set; } 

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("causeWindIntervalTime_")]
        public float CauseWindIntervalTime { get; set; } 

        [JsonPropertyName("whirlWindMoveSpd_")]
        public float WhirlWindMoveSpd { get; set; } 

        [JsonPropertyName("whirlWindAmplitude_")]
        public float WhirlWindAmplitude { get; set; } 

        [JsonPropertyName("whirlWindPeriod_")]
        public float WhirlWindPeriod { get; set; } 

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; 

        [JsonPropertyName("whirlWindInfos_")]
        public BindingList<WhirlWindInfo> WhirlWindInfos { get; set; } = []; 

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; 
    }
}

