using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000ClearRideAction : ActionComponent
{
    [JsonPropertyName("boundPower_")]
    public float BoundPower { get; set; } = 1f; // Offset 0x44

    [JsonPropertyName("blowUpSpeed_")]
    public float BlowUpSpeed { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("isBlow_")]
    public bool IsBlow { get; set; } = false; // Offset 0x4C

    public Em0000ClearRideAction()
    {
    }
}
