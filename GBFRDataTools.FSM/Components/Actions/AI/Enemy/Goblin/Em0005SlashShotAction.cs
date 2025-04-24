using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005TackleAction : Em0005BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005TackleAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x40

    [JsonPropertyName("tackleTurnRate_")]
    public float TackleTurnRate { get; set; } = 0.05f; // Offset 0x44

    public Em0005TackleAction()
    {
    }
}



