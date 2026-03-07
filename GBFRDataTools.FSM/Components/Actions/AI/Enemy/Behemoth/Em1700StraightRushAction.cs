using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700StraightRushAction : Em1700CircleThunderAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700StraightRushAction);

    [JsonPropertyName("isCombo_")]
    public bool IsCombo { get; set; } = false; // Offset 0xA4

    [JsonPropertyName("isRun_")]
    public bool IsRun { get; set; } = false; // Offset 0xA5

    [JsonPropertyName("startSlipRate_")]
    public float StartSlipRate { get; set; } = 0.5f; // Offset 0xAC

    [JsonPropertyName("subSlipRate_")]
    public float SubSlipRate { get; set; } = 0.02f; // Offset 0xB0

    public Em1700StraightRushAction()
    {
    }
}
