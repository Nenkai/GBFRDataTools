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
    Check system files (must be called after BootLoadSystemFile) and returns an event.
    - ToNext - Ok
    - ToError - Errored
    - ToVersionError - Version Error
    - ToCreateSystemFile - System file must be created
    """)]
public class BootCheckSystemFile : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootCheckSystemFile);
}
