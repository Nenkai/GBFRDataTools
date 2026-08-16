using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Flow;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsFlowBranchParam : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsFlowBranchParam);

    [JsonPropertyName("param_")]
    public int Param { get; set; } = 0;

    [JsonPropertyName("label_")]
    public string Label { get; set; }
}
