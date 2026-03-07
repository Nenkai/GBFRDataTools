using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806SwingAuraBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806SwingAuraBreathAction);

    [JsonPropertyName("isBackStep_")]
    public bool IsBackStep { get; set; } = false; // Offset 0x38

    public Em1806SwingAuraBreathAction()
    {
    }
}