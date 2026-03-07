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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802AbsoluteZeroAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802AbsoluteZeroAction);

    [JsonPropertyName("intervalInPatternMaxTimeAILv3_")]
    public float IntervalInPatternMaxTimeAILv3 { get; set; } = 0.8f; // Offset 0x1D8

    [JsonPropertyName("intervalInPatternMaxTimeAILv4_")]
    public float IntervalInPatternMaxTimeAILv4 { get; set; } = 0.8f; // Offset 0x1DC

    public Em1802AbsoluteZeroAction()
    {
    }
}
