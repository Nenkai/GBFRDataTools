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
    public float StormRadius { get; set; } = 5f; // Offset 0xB4

    [JsonPropertyName("stormMoveSpeed_")]
    public float StormMoveSpeed { get; set; } = 0.005f; // Offset 0xBC

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 5f; // Offset 0xC0

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; // Offset 0xC4

    [JsonPropertyName("selfAttackRadius_")]
    public float SelfAttackRadius { get; set; } = 5f; // Offset 0xB8

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } // Offset 0xC8

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } // Offset 0xE8

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } // Offset 0x108

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x128

    [JsonPropertyName("aiLevelParamArrayNihira_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArrayNihira { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x330

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; // Offset 0x538

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; // Offset 0x53C

    [JsonPropertyName("whirlWindWaitTime_")]
    public float WhirlWindWaitTime { get; set; } = 0.5f; // Offset 0x540

    [JsonPropertyName("eventFSMId_")]
    public string EventFSMId { get; set; } // Offset 0x548

    [JsonPropertyName("eventCameraOffset_")]
    public Vector4 EventCameraOffset { get; set; } = new Vector4(0f, 6f, 12f, 1f); // Offset 0x570

    [JsonPropertyName("eventCameraPanRate_")]
    public float EventCameraPanRate { get; set; } = 0.3f; // Offset 0x580

    [JsonPropertyName("eventCameraMoveRate_")]
    public float EventCameraMoveRate { get; set; } = 0.02f; // Offset 0x584

    [JsonPropertyName("eventCameraDegreeY_")]
    public float EventCameraDegreeY { get; set; } = 30f; // Offset 0x588

    [JsonPropertyName("eventExOdUseCount_")]
    public int EventExOdUseCount { get; set; } = 2; // Offset 0x58C

    [JsonPropertyName("eventIdoDistance_")]
    public float EventIdoDistance { get; set; } = 9f; // Offset 0x590

    public Em7201ExContinuousWhirlWindAction()
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

        public WhirlWindInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("useNihiraParam_")]
        public bool UseNihiraParam { get; set; } // Offset 0x8

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0xC

        [JsonPropertyName("causeWindIntervalTime_")]
        public float CauseWindIntervalTime { get; set; } // Offset 0x10

        [JsonPropertyName("whirlWindMoveSpd_")]
        public float WhirlWindMoveSpd { get; set; } // Offset 0x14

        [JsonPropertyName("whirlWindAmplitude_")]
        public float WhirlWindAmplitude { get; set; } // Offset 0x18

        [JsonPropertyName("whirlWindPeriod_")]
        public float WhirlWindPeriod { get; set; } // Offset 0x1C

        [JsonPropertyName("stormSetPositions_")]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; // Offset 0x20

        [JsonPropertyName("whirlWindInfos_")]
        public BindingList<WhirlWindInfo> WhirlWindInfos { get; set; } = []; // Offset 0x38

        [JsonPropertyName("whirlAddRotYInfos_")]
        public BindingList<float> WhirlAddRotYInfos { get; set; } = []; // Offset 0x50

        public DependAILevelParam()
        {
        }
    }
}

