using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class SkipOpenAnim : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SkipOpenAnim);

    [JsonPropertyName("viewName_")]
    public string ViewName { get; set; } // Offset 0x30 - cyan::inplace_string<64>

    [JsonPropertyName("controllerNames_")]
    public BindingList<string> ControllerNames { get; set; } // Offset 0x78 - std::vector<cyan::inplace_string<64>>
}
