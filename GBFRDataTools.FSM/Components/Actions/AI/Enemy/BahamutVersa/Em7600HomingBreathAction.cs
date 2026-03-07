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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600HomingBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600HomingBreathAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 10f; // Offset 0x54

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.01f; // Offset 0x58

    public Em7600HomingBreathAction()
    {
    }
}

