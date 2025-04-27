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

public class Em7201SpinCutAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201SpinCutAction);

    [JsonPropertyName("isReverse_")]
    public bool IsReverse { get; set; } = false; // Offset 0x4F8

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x510

    [JsonPropertyName("shotOffsetRotYDegNormal_")]
    public float ShotOffsetRotYDegNormal { get; set; } = -20f; // Offset 0x4FC

    [JsonPropertyName("shotOffsetRotYDegReverse_")]
    public float ShotOffsetRotYDegReverse { get; set; } = 60f; // Offset 0x500

    [JsonPropertyName("shotWaitTime_")]
    public float ShotWaitTime { get; set; } = 1f; // Offset 0x520

    [JsonPropertyName("normalMotionId_")]
    public string NormalMotionId { get; set; } // Offset 0x528

    [JsonPropertyName("reverseMotionId_")]
    public string ReverseMotionId { get; set; } // Offset 0x548

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x568

    public Em7201SpinCutAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } // Offset 0x8

        [JsonPropertyName("halveShot_")]
        public bool HalveShot { get; set; } // Offset 0xC

        public DependAILevelParam()
        {
        }
    }
}
