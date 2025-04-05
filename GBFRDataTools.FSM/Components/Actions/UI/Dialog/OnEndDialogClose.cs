using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class OnEndDialogClose : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnEndDialogClose);
}
