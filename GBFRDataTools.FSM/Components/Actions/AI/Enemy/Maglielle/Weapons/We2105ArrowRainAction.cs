using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2105ArrowRainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2105ArrowRainAction);

    [JsonPropertyName("isArrowRain_")]
    public bool IsArrowRain { get; set; } = true; // Offset 0x13BC

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x13C0

    [JsonPropertyName("isFolowOwner_")]
    public bool IsFolowOwner { get; set; } = false; // Offset 0x13C4

    public We2105ArrowRainAction()
    {
    }
}

