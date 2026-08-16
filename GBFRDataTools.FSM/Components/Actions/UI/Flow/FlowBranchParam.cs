using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

[GameSupport(GameVersion.EndlessRagnarok)]
public class FlowBranchParam : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowBranchParam);

    [JsonPropertyName("param_")]
    public int Param { get; set; } = 0;

    [JsonPropertyName("label_")]
    public string Label { get; set; }
}
