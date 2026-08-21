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
    public int GaleType { get; set; } = 0; 

    [JsonPropertyName("galeLength_")]
    public float GaleLength { get; set; } = 25f; 

    [JsonPropertyName("galeWidth_")]
    public float GaleWidth { get; set; } = 5f; 

    [JsonPropertyName("galeLifeTime_")]
    public float GaleLifeTime { get; set; } = 6f; 

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 8f; 

    [JsonPropertyName("attractAtkStartRange_")]
    public float AttractAtkStartRange { get; set; } = 7.5f; 

    [JsonPropertyName("attractAtkStartAngle_")]
    public float AttractAtkStartAngle { get; set; } = 60f; 

    [JsonPropertyName("minimumTimeToSelf_")]
    public float MinimumTimeToSelf { get; set; } = 1.8f; 

    [JsonPropertyName("galeSetOffset_")]
    public Vector4 GaleSetOffset { get; set; } = new Vector4(0f, 0f, 5f, 1f);

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } = "1650";

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } = "1651";

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } = "1652";

    [JsonPropertyName("aiLevelParamArray_")]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("cancelGaleTime_")]
    public float CancelGaleTime { get; set; } = 1f; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; }
    }
}
