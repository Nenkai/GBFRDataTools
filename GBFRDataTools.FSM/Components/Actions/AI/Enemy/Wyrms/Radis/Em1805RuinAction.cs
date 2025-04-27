using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805RuinAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805RuinAction);

    [JsonPropertyName("thunderSetMax_")]
    public int ThunderSetMax { get; set; } = 6; // Offset 0xDA0

    [JsonPropertyName("thunderPursuitMax_")]
    public int ThunderPursuitMax { get; set; } = 4; // Offset 0xDA4

    [JsonPropertyName("thunderPursuitOuter_")]
    public int ThunderPursuitOuter { get; set; } = 2; // Offset 0xDA8

    [JsonPropertyName("thunderWaitPlayer00_")]
    public float ThunderWaitPlayer00 { get; set; } = 0.01f; // Offset 0xDAC

    [JsonPropertyName("thunderWaitPlayer01_")]
    public float ThunderWaitPlayer01 { get; set; } = 0.3f; // Offset 0xDB0

    [JsonPropertyName("thunderWaitPlayer02_")]
    public float ThunderWaitPlayer02 { get; set; } = 0.6f; // Offset 0xDB4

    [JsonPropertyName("thunderWaitPlayer03_")]
    public float ThunderWaitPlayer03 { get; set; } = 0.9f; // Offset 0xDB8

    [JsonPropertyName("thunderWaitTime_")]
    public float ThunderWaitTime { get; set; } = 0.3f; // Offset 0xDBC

    [JsonPropertyName("thunderOnesetWaitTime_")]
    public float ThunderOnesetWaitTime { get; set; } = 0.3f; // Offset 0xDC0

    [JsonPropertyName("thunderParalyzeWaitTime_")]
    public float ThunderParalyzeWaitTime { get; set; } = 0.6f; // Offset 0xDC4

    [JsonPropertyName("thunderOnesetParalyzeWaitTime_")]
    public float ThunderOnesetParalyzeWaitTime { get; set; } = 0.6f; // Offset 0xDC8

    public Em1805RuinAction()
    {
    }
}

