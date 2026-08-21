using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SetSuspendAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SetSuspendAction);

    [JsonPropertyName("isChangeWear_")]
    public bool IsChangeWear { get; set; } = true; 

    [JsonPropertyName("isChangeWe2104_")]
    public bool IsChangeWe2104 { get; set; } = true; 

    [JsonPropertyName("isChangeWe2105_")]
    public bool IsChangeWe2105 { get; set; } = true; 

    [JsonPropertyName("isSuspendWear_")]
    public bool IsSuspendWear { get; set; } = true; 

    [JsonPropertyName("isSuspendWe2104_")]
    public bool IsSuspendWe2104 { get; set; } = true; 

    [JsonPropertyName("isSuspendWe2105_")]
    public bool IsSuspendWe2105 { get; set; } = true; 

    [JsonPropertyName("isUndoEnd_")]
    public bool IsUndoEnd { get; set; } = true; 
}