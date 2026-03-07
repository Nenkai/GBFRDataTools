using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class We7700MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7700MoveAction);

    [JsonPropertyName("velocity_")]
    public Vector4 Velocity { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x30

    public We7700MoveAction()
    {
    }
}
