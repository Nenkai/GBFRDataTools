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

public class Em1500BaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BaseAction);

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; // Offset 0x30

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false; // Offset 0x31

    public Em1500BaseAction()
    {
    }
}
