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

public class Em1500GuardAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500GuardAction);

    [JsonPropertyName("guardTime_")]
    public float GuardTime { get; set; } = 6f; // Offset 0x58

    [JsonPropertyName("attackLayer_")]
    public int AttackLayer { get; set; } = 3; // Offset 0x5C

    public Em1500GuardAction()
    {
    }
}