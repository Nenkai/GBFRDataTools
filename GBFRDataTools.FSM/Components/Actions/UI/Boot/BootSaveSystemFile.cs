using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Boot;

/// <summary>
/// Checks system save files
/// </summary>
[Description("""
    Returns event:
    - ToNext: If successful
    """)]
public class BootSaveSystemFile : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootSaveSystemFile);
}
