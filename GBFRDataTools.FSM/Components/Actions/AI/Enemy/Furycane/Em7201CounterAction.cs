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

public class Em7201CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CounterAction);

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 5f;

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } = "1700";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; 

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; 

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 0.5f; 

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f; 

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1.5f; 

    [JsonPropertyName("stormInitRadius_")]
    public float StormInitRadius { get; set; } = 7.2f; 

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW; 

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
        [JsonPropertyName("causeWindIntervalTime_")]
        public float CauseWindIntervalTime { get; set; } 

        [JsonPropertyName("whirlWindMoveSpd_")]
        public float WhirlWindMoveSpd { get; set; } 

        [JsonPropertyName("whirlWindAmplitude_")]
        public float WhirlWindAmplitude { get; set; } 

        [JsonPropertyName("whirlWindPeriod_")]
        public float WhirlWindPeriod { get; set; } 

        [JsonPropertyName("whirlWindInfos_")]
        public BindingList<WhirlWindInfo> WhirlWindInfos { get; set; } = []; 

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; 

    }
}

