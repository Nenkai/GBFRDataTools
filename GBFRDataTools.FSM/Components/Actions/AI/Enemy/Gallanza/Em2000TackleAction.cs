using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000TackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000TackleAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f; // Offset 0x58

    [JsonPropertyName("startInterSec_")]
    public float StartInterSec { get; set; } = -1f; // Offset 0x5C

    public Em2000TackleAction()
    {
    }
}
