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
    public float StormRadius { get; set; } = 5f; // Offset 0xC8

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 5f; // Offset 0xCC

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } // Offset 0xD0

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0xF0

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; // Offset 0x258

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; // Offset 0x25C

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 0.5f; // Offset 0x260

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f; // Offset 0x264

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1.5f; // Offset 0x280

    [JsonPropertyName("stormInitRadius_")]
    public float StormInitRadius { get; set; } = 7.2f; // Offset 0x268

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x270

    public Em7201CounterAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } // Offset 0x10
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
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
        public BindingList<WhirlWindInfo> WhirlWindInfos { get; set; } = []; // Offset 0x18

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; // Offset 0x30

    }
}

