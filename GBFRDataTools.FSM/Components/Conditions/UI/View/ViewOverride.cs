using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.View;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ViewOverride : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewOverride);

    [JsonPropertyName("beforeViewIDs_")]
    public BindingList<string> BeforeViewIDs { get; set; } = [];

    [JsonPropertyName("afterViewIDs_")]
    public BindingList<string> AfterViewIDs { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;
}
