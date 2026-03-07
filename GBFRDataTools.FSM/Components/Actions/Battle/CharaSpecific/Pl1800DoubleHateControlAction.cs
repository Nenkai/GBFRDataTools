using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle.CharaSpecific;

public class Pl1800DoubleHateControlAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Pl1800DoubleHateControlAction);

    [JsonPropertyName("areaRadius_")]
    public float AreaRadius { get; set; } = 5.0f;
}
