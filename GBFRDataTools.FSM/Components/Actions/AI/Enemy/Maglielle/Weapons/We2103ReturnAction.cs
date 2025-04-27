using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2103ReturnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2103ReturnAction);

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 2f; // Offset 0xD0

    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; } = 0.25f; // Offset 0xD4

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0xD8

    public We2103ReturnAction()
    {
    }
}
