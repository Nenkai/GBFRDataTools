using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Trial;

public class TrialModeBranch : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TrialModeBranch);

    [JsonPropertyName("state_")]
    public EnumString<TrialModeBranchState> State { get; set; } // Offset 0x38

    public TrialModeBranch()
    {
    }
}

public enum TrialModeBranchState
{
    None = 0,
    Free = 1,
    Time = 2,
    Boss = 3,
    Practice = 4,
    Action = 5,
}