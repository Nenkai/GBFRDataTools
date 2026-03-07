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
    public BindingList<AdjustedData> AdjustedDatas { get; set; } = []; // Offset 0xD0

    [JsonPropertyName("bStartVanishStorm_")]
    public bool BStartVanishStorm { get; set; } = false; // Offset 0xE8

    [JsonPropertyName("createSmallWindCondition_")]
    public int CreateSmallWindCondition { get; set; } = 0; // Offset 0xEC

    [JsonPropertyName("createBigStormCondition_")]
    public int CreateBigStormCondition { get; set; } = 0; // Offset 0xF0

    [JsonPropertyName("createSignTime_")]
    public float CreateSignTime { get; set; } = 1.5f; // Offset 0xF4

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 1f; // Offset 0xF8

    [JsonPropertyName("smallWindAiLevelParamArray_")]
    [Editable(false)]
    public BindingList<SmallWhirlWindAILevelParam> SmallWindAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new SmallWhirlWindAILevelParam(), 5)]; // Offset 0x100

    [JsonPropertyName("bigStormAiLevelParamArray_")]
    [Editable(false)]
    public BindingList<BigStormAILevelParam> BigStormAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new BigStormAILevelParam(), 5)]; // Offset 0x290

    [JsonPropertyName("baseAiLevelParamArray_")]
    public BindingList<BaseAILevelParam> BaseAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new BaseAILevelParam(), 5)]; // Offset 0x420

    [JsonPropertyName("slowRateAiLevelParamArray_")]
    public BindingList<SlowRateAILevelParam> SlowRateAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new SlowRateAILevelParam(), 5)]; // Offset 0x470

    public Em7200ComboBaseAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AdjustedData
    {
        [JsonPropertyName("turnType_")]
        public int TurnType { get; set; } // Offset 0x10

        [JsonPropertyName("turnRate_")]
        public float TurnRate { get; set; } // Offset 0x14

        [JsonPropertyName("turnDirOffsetRadian_")]
        public float TurnDirOffsetRadian { get; set; } // Offset 0x18

        [JsonPropertyName("bLeftTurn_")]
        public bool BLeftTurn { get; set; } // Offset 0x1C

        [JsonPropertyName("bRightTurn_")]
        public bool BRightTurn { get; set; } // Offset 0x1D

        [JsonPropertyName("adjustLen_")]
        public Vector4 AdjustLen { get; set; } // Offset 0x20

        public AdjustedData()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BigStormSetPosInfo
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x10

        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        public BigStormSetPosInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SmallWhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } // Offset 0x10

        public SmallWhirlWindInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SmallWhirlWindAILevelParam
    {
        [JsonPropertyName("causeWindIntervalTime_")]
        public float CauseWindIntervalTime { get; set; } // Offset 0x8

        [JsonPropertyName("whirlWindMoveSpd_")]
        public float WhirlWindMoveSpd { get; set; } // Offset 0xC

        [JsonPropertyName("whirlWindAmplitude_")]
        public float WhirlWindAmplitude { get; set; } // Offset 0x10

        [JsonPropertyName("whirlWindPeriod_")]
        public float WhirlWindPeriod { get; set; } // Offset 0x14

        [JsonPropertyName("whirlWindInfos_")]
        public BindingList<SmallWhirlWindInfo> WhirlWindInfos { get; set; } = []; // Offset 0x18

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; // Offset 0x30

        [JsonPropertyName("marshDistanceMin_")]
        public float MarshDistanceMin { get; set; } // Offset 0x48

        [JsonPropertyName("marshDistanceMax_")]
        public float MarshDistanceMax { get; set; } // Offset 0x4C

        public SmallWhirlWindAILevelParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BigStormAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x8

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } // Offset 0xC

        [JsonPropertyName("causeStormIntervalTime_")]
        public float CauseStormIntervalTime { get; set; } // Offset 0x10

        [JsonPropertyName("stormRadius_")]
        public float StormRadius { get; set; } // Offset 0x14

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } // Offset 0x18

        [JsonPropertyName("stormMoveSpeed_")]
        public float StormMoveSpeed { get; set; } // Offset 0x1C

        [JsonPropertyName("stormRandomRotY_")]
        public float StormRandomRotY { get; set; } // Offset 0x20

        [JsonPropertyName("stormSetRandomRange_")]
        public float StormSetRandomRange { get; set; } // Offset 0x24

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<BigStormSetPosInfo> StormSetPositions { get; set; } = []; // Offset 0x28

        [JsonPropertyName("normalStormMax_")]
        public int NormalStormMax { get; set; } // Offset 0x40

        [JsonPropertyName("odStormMax_")]
        public int OdStormMax { get; set; } // Offset 0x44

        [JsonPropertyName("stormCustomType_")]
        public int StormCustomType { get; set; } // Offset 0x48

        public BigStormAILevelParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BaseAILevelParam
    {
        [JsonPropertyName("addAttackRatio_")]
        public float AddAttackRatio { get; set; } // Offset 0x8

        [JsonPropertyName("addAttackCheckPattern_")]
        public int AddAttackCheckPattern { get; set; } // Offset 0xC

        public BaseAILevelParam()
        {
        }
    }
    
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SlowRateAILevelParam
    {
        [JsonPropertyName("slowType_")]
        public int SlowType { get; set; } // Offset 0x8

        [JsonPropertyName("slowRate_")]
        public float SlowRate { get; set; } // Offset 0xC

        public SlowRateAILevelParam()
        {
        }
    }
}




