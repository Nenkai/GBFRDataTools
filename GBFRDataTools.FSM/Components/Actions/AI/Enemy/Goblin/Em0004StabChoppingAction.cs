using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004StabChoppingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004StabChoppingAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x30

    public Em0004StabChoppingAction()
    {
    }
}
