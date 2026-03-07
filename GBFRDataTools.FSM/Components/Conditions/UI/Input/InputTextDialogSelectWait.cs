using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Input;

public class InputTextDialogSelectWait : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(InputTextDialogSelectWait);

    public InputTextDialogSelectWait()
    {
    }
}

