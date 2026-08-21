using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005JumpSlashAction : Em0005BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005JumpSlashAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("isCancelAction_")]
    public bool IsCancelAction { get; set; } = true; 
}
