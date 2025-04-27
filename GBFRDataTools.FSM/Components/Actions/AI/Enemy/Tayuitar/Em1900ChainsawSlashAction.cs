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
    public bool IsLeftArm { get; set; } = false; // Offset 0x78

    [JsonPropertyName("isHorizontal_")]
    public bool IsHorizontal { get; set; } = false; // Offset 0x79

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 3f; // Offset 0x7C

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 0.1f; // Offset 0x80

    [JsonPropertyName("resetHitListTime_")]
    public float ResetHitListTime { get; set; } = 0.2f; // Offset 0x84

    [JsonPropertyName("homingRateSwingDown_")]
    public float HomingRateSwingDown { get; set; } = 0.5f; // Offset 0x88

    [JsonPropertyName("homingRateLoop_")]
    public float HomingRateLoop { get; set; } = 0.02f; // Offset 0x8C

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; // Offset 0x90

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false; // Offset 0x91

    public Em1900ChainsawSlashAction()
    {
    }
}
