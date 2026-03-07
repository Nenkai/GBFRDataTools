using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class CanMatchingSetting : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CanMatchingSetting);

    [JsonPropertyName("isReverseSuccess_")]
    public bool IsReverseSuccess { get; set; } = false; // Offset 0x30

    public CanMatchingSetting()
    {
    }
}