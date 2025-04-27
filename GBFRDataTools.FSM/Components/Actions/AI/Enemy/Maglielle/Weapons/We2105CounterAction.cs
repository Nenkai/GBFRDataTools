using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2105CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2105CounterAction);

    [JsonPropertyName("swordDist_")]
    public float SwordDist { get; set; } = 40f; // Offset 0x1C4

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 25f; // Offset 0x1C8

    public We2105CounterAction()
    {
    }
}

