using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

[Description("""
    Closes a ui view/controller by name, aka ui viewb file based on controller name.
    It should have been opened using ViewClose first.

    Note: List of views appears to be mostly hardcoded on the executable as hash of the name.
    Example: LoadingIcon maps to ControllerLoadingIcon.
    """)]
public class ViewClose : ViewOpenClose
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewClose);

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false;

    public override string GetCaption()
    {
        return string.Join("\n", Views);
    }
}
