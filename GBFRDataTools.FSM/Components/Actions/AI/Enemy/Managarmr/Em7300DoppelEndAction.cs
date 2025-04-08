using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DoppelEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DoppelEndAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;
}
