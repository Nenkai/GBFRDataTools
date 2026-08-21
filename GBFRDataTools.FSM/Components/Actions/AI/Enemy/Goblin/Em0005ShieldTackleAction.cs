using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005ShieldTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005ShieldTackleAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("changeFinishMotion_")]
    public bool ChangeFinishMotion { get; set; } = false; 
}
