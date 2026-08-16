using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

[GameSupport(GameVersion.EndlessRagnarok)]
public class FlowBranchParamClear : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowBranchParamClear);

    [JsonPropertyName("label_")]
    public string Label { get; set; } // Offset 0x30

    [JsonPropertyName("clearAll_")]
    public bool ClearAll { get; set; } = false;
}
