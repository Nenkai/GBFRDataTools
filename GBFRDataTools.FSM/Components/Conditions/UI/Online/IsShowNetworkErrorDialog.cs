using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsShowNetworkErrorDialog : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsShowNetworkErrorDialog);

    public IsShowNetworkErrorDialog()
    {
    }
}