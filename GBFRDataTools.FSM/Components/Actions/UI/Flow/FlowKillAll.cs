using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

public class FlowKillAll : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowKillAll);

    public FlowKillAll()
    {
    }
}
