using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300SomersaultTailAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300SomersaultTailAction);

    [JsonPropertyName("moveMaxDist_")]
    public float MoveMaxDist { get; set; } = 20f; // Offset 0x60

    public Em7300SomersaultTailAction()
    {
    }
}
