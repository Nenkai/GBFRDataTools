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

public class We7700SwingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7700SwingAction);

    [JsonPropertyName("isVertical_")]
    public bool IsVertical { get; set; } = false; // Offset 0x78

    public We7700SwingAction()
    {
    }
}
