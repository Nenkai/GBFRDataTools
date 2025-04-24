using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002StepAction);

    [JsonPropertyName("stepDir_")]
    public int StepDir { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f; // Offset 0x30

    public Em0002StepAction()
    {
    }
}
