using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Item;

public class HaveItem : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(HaveItem);

    [JsonPropertyName("itemIDString_")]
    public string ItemIDString { get; set; } // Offset 0x38

    [JsonPropertyName("once_")]
    public bool Once { get; set; } = false; // Offset 0x5C

    public HaveItem()
    {
    }
}
