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

public class Em1500EarthquakeLariatAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500EarthquakeLariatAction);

    [JsonPropertyName("rockNum_")]
    public int RockNum { get; set; } = 10; // Offset 0x288

    public Em1500EarthquakeLariatAction()
    {
    }
}