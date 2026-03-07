using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200CauseGaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200CauseGaleAction);

    [JsonPropertyName("galeType_")]
    public int GaleType { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("galeLength_")]
    public float GaleLength { get; set; } = 25f; // Offset 0x74

    [JsonPropertyName("galeWidth_")]
    public float GaleWidth { get; set; } = 5f; // Offset 0x78

    [JsonPropertyName("galeLifeTime_")]
    public float GaleLifeTime { get; set; } = 6f; // Offset 0x7C

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 8f; // Offset 0x80

    [JsonPropertyName("attractAtkStartRange_")]
    public float AttractAtkStartRange { get; set; } = 7.5f; // Offset 0x84

    [JsonPropertyName("attractAtkStartAngle_")]
    public float AttractAtkStartAngle { get; set; } = 60f; // Offset 0x88

    [JsonPropertyName("minimumTimeToSelf_")]
    public float MinimumTimeToSelf { get; set; } = 1.8f; // Offset 0x8C

    [JsonPropertyName("galeSetOffset_")]
    public Vector4 GaleSetOffset { get; set; } = new Vector4(0f, 0f, 5f, 1f); // Offset 0x90

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } // Offset 0xA0

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } // Offset 0xA8

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } // Offset 0xB0

    [JsonPropertyName("aiLevelParamArray_")]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0xB8

    [JsonPropertyName("cancelGaleTime_")]
    public float CancelGaleTime { get; set; } = 1f; // Offset 0x108

    public Em7200CauseGaleAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x8

        public DependAILevelParam()
        {
        }
    }
}
