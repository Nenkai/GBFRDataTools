using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0502MagmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0502MagmaAction);

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0;
}
