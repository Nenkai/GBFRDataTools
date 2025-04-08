using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Boot;

[Description("""
    Returns event:
    - ToNext: if successful
    - ToInitialSettings: 
    """)]
public class BootCheckInitialSettings : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootCheckInitialSettings);
}
