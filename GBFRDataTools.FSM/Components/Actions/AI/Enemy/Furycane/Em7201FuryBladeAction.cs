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

public class Em7201FuryBladeAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201FuryBladeAction);

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0; 

    [JsonPropertyName("targetAttackHate_")]
    public int TargetAttackHate { get; set; } = 90; 

    [JsonPropertyName("strongWindType_")]
    public int StrongWindType { get; set; } = 0; 

    [JsonPropertyName("shotLifeTime_")]
    public float ShotLifeTime { get; set; } = 20f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 16f; 

    [JsonPropertyName("shotOffset_")]
    [Editable(false)]
    public BindingList<Vector4> ShotOffset { get; set; } = [.. Enumerable.Repeat(new Vector4(), 2)];

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "1520";

    [JsonPropertyName("loopMotionId_")]
    public string? LoopMotionId { get; set; } = "1521";

    [JsonPropertyName("endMotionId_")]
    public string? EndMotionId { get; set; } = "1522";

    [JsonPropertyName("baseAiLevelParamArray_")]
    public new BindingList<BaseAILevelParam> BaseAiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new BaseAILevelParam(), 5)];  

    public new class BaseAILevelParam
    {
        [JsonPropertyName("addAttackRatio_")]
        public float AddAttackRatio { get; set; }

        [JsonPropertyName("addAttackCheckPattern_")]
        public int AddAttackCheckPattern { get; set; }

        [JsonPropertyName("loopNum_")]
        public int LoopNum { get; set; } 

        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } 
    }
}




