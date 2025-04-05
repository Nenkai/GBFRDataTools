using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

/// <summary>
/// Checks system save files
/// </summary>
public class BootSaveSystemFile : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootSaveSystemFile);
}
