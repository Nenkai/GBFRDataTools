using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.View;

public class IsWaitView : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsWaitView);

    [JsonPropertyName("viewName_")]
    public string ViewName { get; set; } // Offset 0x38

    public IsWaitView()
    {
    }
}
