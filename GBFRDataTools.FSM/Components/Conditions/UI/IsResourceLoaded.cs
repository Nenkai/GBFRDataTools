using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsResourceLoaded : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsResourceLoaded);

    [JsonPropertyName("category_")]
    public EnumString Category { get; set; } // Offset 0x38
}
