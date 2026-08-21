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

public class Em7200ComboBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200ComboBaseAction);

    [JsonPropertyName("adjustedDatas_")]
    public BindingList<AdjustedData> AdjustedDatas { get; set; } = []; 

    [JsonPropertyName("bStartVanishStorm_")]
    public bool BStartVanishStorm { get; set; } = false; 

    [JsonPropertyName("createSmallWindCondition_")]
    public int CreateSmallWindCondition { get; set; } = 0; 

    [JsonPropertyName("createBigStormCondition_")]
    public int CreateBigStormCondition { get; set; } = 0; 

    [JsonPropertyName("createSignTime_")]
    public float CreateSignTime { get; set; } = 1.5f; 

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 1f; 

    [JsonPropertyName("smallWindAiLevelParamArray_")]
    [Editable(false)]
    public BindingList<SmallWhirlWindAILevelParam> SmallWindAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new SmallWhirlWindAILevelParam(), 5)]; 

    [JsonPropertyName("bigStormAiLevelParamArray_")]
    [Editable(false)]
    public BindingList<BigStormAILevelParam> BigStormAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new BigStormAILevelParam(), 5)]; 

    [JsonPropertyName("baseAiLevelParamArray_")]
    public BindingList<BaseAILevelParam> BaseAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new BaseAILevelParam(), 5)]; 

    [JsonPropertyName("slowRateAiLevelParamArray_")]
    public BindingList<SlowRateAILevelParam> SlowRateAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new SlowRateAILevelParam(), 5)]; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AdjustedData
    {
        [JsonPropertyName("turnType_")]
        public int TurnType { get; set; } 

        [JsonPropertyName("turnRate_")]
        public float TurnRate { get; set; } 

        [JsonPropertyName("turnDirOffsetRadian_")]
        public float TurnDirOffsetRadian { get; set; } 

        [JsonPropertyName("bLeftTurn_")]
        public bool BLeftTurn { get; set; } 

        [JsonPropertyName("bRightTurn_")]
        public bool BRightTurn { get; set; } 

        [JsonPropertyName("adjustLen_")]
        public Vector4 AdjustLen { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BigStormSetPosInfo
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; } 

        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SmallWhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SmallWhirlWindAILevelParam
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
        public BindingList<SmallWhirlWindInfo> WhirlWindInfos { get; set; } = []; 

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; 

        [JsonPropertyName("marshDistanceMin_")]
        public float MarshDistanceMin { get; set; } 

        [JsonPropertyName("marshDistanceMax_")]
        public float MarshDistanceMax { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BigStormAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } 

        [JsonPropertyName("causeStormIntervalTime_")]
        public float CauseStormIntervalTime { get; set; } 

        [JsonPropertyName("stormRadius_")]
        public float StormRadius { get; set; } 

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } 

        [JsonPropertyName("stormMoveSpeed_")]
        public float StormMoveSpeed { get; set; } 

        [JsonPropertyName("stormRandomRotY_")]
        public float StormRandomRotY { get; set; } 

        [JsonPropertyName("stormSetRandomRange_")]
        public float StormSetRandomRange { get; set; } 

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<BigStormSetPosInfo> StormSetPositions { get; set; } = []; 

        [JsonPropertyName("normalStormMax_")]
        public int NormalStormMax { get; set; } 

        [JsonPropertyName("odStormMax_")]
        public int OdStormMax { get; set; } 

        [JsonPropertyName("stormCustomType_")]
        public int StormCustomType { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BaseAILevelParam
    {
        [JsonPropertyName("addAttackRatio_")]
        public float AddAttackRatio { get; set; } 

        [JsonPropertyName("addAttackCheckPattern_")]
        public int AddAttackCheckPattern { get; set; } 
    }
    
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SlowRateAILevelParam
    {
        [JsonPropertyName("slowType_")]
        public int SlowType { get; set; } 

        [JsonPropertyName("slowRate_")]
        public float SlowRate { get; set; } 
    }
}




