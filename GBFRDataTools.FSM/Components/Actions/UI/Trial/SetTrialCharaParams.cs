using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class SetTrialCharaParams : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTrialCharaParams);

    public SetTrialCharaParams()
    {
    }
}