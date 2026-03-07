using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Conditions.UI.Flow;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Tutorial;

public class WindowTutorialResult : FlowResult
{
    [JsonIgnore]
    public override string ComponentName => nameof(WindowTutorialResult);
}
