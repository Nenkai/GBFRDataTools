using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806RollAuraBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806RollAuraBreathAction);

    [JsonPropertyName("isDownLoopAnimEnd_")]
    public bool IsDownLoopAnimEnd { get; set; } = true; // Offset 0xB6

    public Em1806RollAuraBreathAction()
    {
    }
}