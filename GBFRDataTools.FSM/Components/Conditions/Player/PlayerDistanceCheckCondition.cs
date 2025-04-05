using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class PlayerDistanceCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerDistanceCheckCondition);

    [JsonPropertyName("distance_")]
    public float Distance { get; set; } = 1.0f;
}
