using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200SelfDamageAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200SelfDamageAction);

    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; } = 3.0f;

    [JsonPropertyName("eventAttackRate_")]
    public float EventAttackRate { get; set; } = 0.08f;
}
