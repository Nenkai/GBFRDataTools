using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806FrontAuraBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806FrontAuraBreathAction);

    [JsonPropertyName("isStepStart_")]
    public bool IsStepStart { get; set; } = false; // Offset 0x42

    [JsonPropertyName("isHomming_")]
    public bool IsHomming { get; set; } = false; // Offset 0x43

    [JsonPropertyName("isNoStopBreath_")]
    public bool IsNoStopBreath { get; set; } = true; // Offset 0x44

    [JsonPropertyName("isLoopAnimEnd_")]
    public bool IsLoopAnimEnd { get; set; } = true; // Offset 0x45

    public Em1806FrontAuraBreathAction()
    {
    }
}