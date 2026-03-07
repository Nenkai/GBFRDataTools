using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Boot;

[Description("Starts loading system files. Result must be checked using BootCheckSystemFile.")]
public class BootLoadSystemFile : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootLoadSystemFile);
}
