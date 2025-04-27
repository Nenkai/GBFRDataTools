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
    public bool IsChangeWear { get; set; } = true; // Offset 0x30

    [JsonPropertyName("isChangeWe2104_")]
    public bool IsChangeWe2104 { get; set; } = true; // Offset 0x31

    [JsonPropertyName("isChangeWe2105_")]
    public bool IsChangeWe2105 { get; set; } = true; // Offset 0x32

    [JsonPropertyName("isSuspendWear_")]
    public bool IsSuspendWear { get; set; } = true; // Offset 0x33

    [JsonPropertyName("isSuspendWe2104_")]
    public bool IsSuspendWe2104 { get; set; } = true; // Offset 0x34

    [JsonPropertyName("isSuspendWe2105_")]
    public bool IsSuspendWe2105 { get; set; } = true; // Offset 0x35

    [JsonPropertyName("isUndoEnd_")]
    public bool IsUndoEnd { get; set; } = true; // Offset 0x36

    public Em2100SetSuspendAction()
    {
    }
}