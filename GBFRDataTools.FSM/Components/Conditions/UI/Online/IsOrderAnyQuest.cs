using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsOrderAnyQuest : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsOrderAnyQuest);

    public IsOrderAnyQuest()
    {
    }
}
