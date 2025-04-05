using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7310CrackPhaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7310CrackPhaseAction);

    [JsonPropertyName("phase_")]
    public uint Phase { get; set; } = 0;
}
