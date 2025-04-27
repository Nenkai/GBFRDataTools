using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000SpearAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000SpearAbilityAction);

    [JsonPropertyName("timeoutSec_")]
    public float TimeoutSec { get; set; } = 1f; // Offset 0x94

    [JsonPropertyName("stopDistanceXZ_")]
    public float StopDistanceXZ { get; set; } = 10f; // Offset 0x98

    [JsonPropertyName("isAppear_")]
    public bool IsAppear { get; set; } = false; // Offset 0x9C

    public Em2000SpearAbilityAction()
    {
    }
}
