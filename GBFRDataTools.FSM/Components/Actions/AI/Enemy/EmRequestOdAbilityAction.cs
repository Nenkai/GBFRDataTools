using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmRequestOdAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmRequestOdAbilityAction);

    [JsonPropertyName("isIgnoreCoolTime_")]
    public bool IsIgnoreCoolTime { get; set; } = false; // Offset 0x30

    public EmRequestOdAbilityAction()
    {
    }
}
