using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706BaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706BaseAction);

    [JsonPropertyName("isSingleAction_")]
    public bool IsSingleAction { get; set; } = false; // Offset 0x33

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; // Offset 0x30

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false; // Offset 0x31

    [JsonPropertyName("isActionEndDefaultHeight_")]
    public bool IsActionEndDefaultHeight { get; set; } = false; // Offset 0x32

    public Em0706BaseAction()
    {
    }
}