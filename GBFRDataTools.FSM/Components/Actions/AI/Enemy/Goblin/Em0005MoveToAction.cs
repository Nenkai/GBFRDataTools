using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005MoveToAction);

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 4f; // Offset 0x38

    public Em0005MoveToAction()
    {
    }
}
