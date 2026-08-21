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
    public bool IsReverse { get; set; } = false; 

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("shotOffsetRotYDegNormal_")]
    public float ShotOffsetRotYDegNormal { get; set; } = -20f; 

    [JsonPropertyName("shotOffsetRotYDegReverse_")]
    public float ShotOffsetRotYDegReverse { get; set; } = 60f; 

    [JsonPropertyName("shotWaitTime_")]
    public float ShotWaitTime { get; set; } = 1f;

    [JsonPropertyName("normalMotionId_")]
    public string? NormalMotionId { get; set; } = "1a20";

    [JsonPropertyName("reverseMotionId_")]
    public string? ReverseMotionId { get; set; } = "1a21";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } 

        [JsonPropertyName("halveShot_")]
        public bool HalveShot { get; set; } 
    }
}
