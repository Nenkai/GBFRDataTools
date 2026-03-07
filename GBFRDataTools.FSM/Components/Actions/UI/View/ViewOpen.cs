using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

[Description("""
    Opens a ui view/controller by name, aka ui viewb file based on controller name.
    Note: List of views appears to be mostly hardcoded on the executable as hash of the name.
    Example: LoadingIcon maps to ControllerLoadingIcon.
    """)]
public class ViewOpen : ViewOpenClose
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewOpen);

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false;

    public override string GetCaption()
    {
        return string.Join("\n", Views);
    }
}
