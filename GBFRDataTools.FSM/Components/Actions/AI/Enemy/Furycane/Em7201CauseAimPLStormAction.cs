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

public class Em7201CauseAimPLStormAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseAimPLStormAction);

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("nextCoolTime_")]
    public float NextCoolTime { get; set; } = 0f;

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1200";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0;

    [JsonPropertyName("signStartSe_")]
    public string? SignStartSe { get; set; } = "em7200_atk_magiccircle_sign_start";

    [JsonPropertyName("signEndSe_")]
    public string? SignEndSe { get; set; } = "em7200_atk_magiccircle_sign_end";

    public class DependAILevelParam
    {
        [JsonPropertyName("isUseStorm_")]
        public bool IsUseStorm { get; set; } 

        [JsonPropertyName("stormMoveSpd_")]
        public float StormMoveSpd { get; set; } 

        [JsonPropertyName("stormStopHomingDist_")]
        public float StormStopHomingDist { get; set; } 

        [JsonPropertyName("stormStartMoveTime_")]
        public float StormStartMoveTime { get; set; } 

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } 

        [JsonPropertyName("isHoming_")]
        public bool IsHoming { get; set; } 

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } 
    }
}