using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000TacklePickUpSpearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000TacklePickUpSpearAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f; 

    [JsonPropertyName("timeoutSec_")]
    public float TimeoutSec { get; set; } = 1f; 

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 60f;
}
