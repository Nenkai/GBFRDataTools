using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004SlashComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004SlashComboAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 3f; // Offset 0x34

    [JsonPropertyName("nextAction_")]
    public int NextAction { get; set; } = 0; // Offset 0x38

    public Em0004SlashComboAction()
    {
    }
}
