using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Trial;

public class IsChangeTrialCharaParams : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsChangeTrialCharaParams);

    public IsChangeTrialCharaParams()
    {
    }
}