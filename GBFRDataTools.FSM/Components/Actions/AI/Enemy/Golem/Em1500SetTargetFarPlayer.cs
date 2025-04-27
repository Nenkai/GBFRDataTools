using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500SetPartsDamageActionCancel : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500SetPartsDamageActionCancel);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x30

    public Em1500SetPartsDamageActionCancel()
    {
    }
}