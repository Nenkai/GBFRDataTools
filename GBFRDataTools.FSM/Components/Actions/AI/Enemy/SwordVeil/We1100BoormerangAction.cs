using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class We1100BoormerangAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1100BoormerangAction);

    [JsonPropertyName("attackDistance_")]
    public float AttackDistance { get; set; } = 15f; // Offset 0x38

    [JsonPropertyName("swordMoveSpeed_")]
    public float SwordMoveSpeed { get; set; } = 12f; // Offset 0x3C

    public We1100BoormerangAction()
    {
    }
}
