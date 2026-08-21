using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900ChainsawSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900ChainsawSlashAction);

    [JsonPropertyName("isLeftArm_")]
    public bool IsLeftArm { get; set; } = false; 

    [JsonPropertyName("isHorizontal_")]
    public bool IsHorizontal { get; set; } = false; 

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 3f; 

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 0.1f; 

    [JsonPropertyName("resetHitListTime_")]
    public float ResetHitListTime { get; set; } = 0.2f; 

    [JsonPropertyName("homingRateSwingDown_")]
    public float HomingRateSwingDown { get; set; } = 0.5f; 

    [JsonPropertyName("homingRateLoop_")]
    public float HomingRateLoop { get; set; } = 0.02f; 

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; 

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false; 
}