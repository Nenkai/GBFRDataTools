using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

public class ViewCloseAnimationSkip : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewCloseAnimationSkip);

    [JsonPropertyName("viewName_")]
    public string ViewName { get; set; } // Offset 0x30

    public ViewCloseAnimationSkip()
    {
    }
}
