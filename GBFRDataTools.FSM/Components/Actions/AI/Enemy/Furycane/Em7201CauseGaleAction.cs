using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201CauseGaleAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseGaleAction);

    [JsonPropertyName("galeType_")]
    public int GaleType { get; set; } = 0; 

    [JsonPropertyName("attractAtkStartRange_")]
    public float AttractAtkStartRange { get; set; } = 7.5f; 

    [JsonPropertyName("causeToSelfMinTime_")]
    public float CauseToSelfMinTime { get; set; } = 1.8f; 

    [JsonPropertyName("nextCoolTime_")]
    [Editable(false)]
    public BindingList<float> NextCoolTime { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("motionIdStart_")]
    public string? MotionIdStart { get; set; } = "1650";

    [JsonPropertyName("motionIdLoop_")]
    public string? MotionIdLoop { get; set; } = "1651";

    [JsonPropertyName("motionIdEnd_")]
    public string? MotionIdEnd { get; set; } = "1652";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)];  

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1f; 

    [JsonPropertyName("attackSignRadius_")]
    public float AttackSignRadius { get; set; } = 8f; 

    [JsonPropertyName("attackSignLength_")]
    public float AttackSignLength { get; set; } = 0f; 

    public class DependAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("galeLifeTime_")]
        public float GaleLifeTime { get; set; } 

        [JsonPropertyName("loopMotionTime_")]
        public float LoopMotionTime { get; set; } 

        [JsonPropertyName("isForceAttractAttack_")]
        public bool IsForceAttractAttack { get; set; } 
    }
}