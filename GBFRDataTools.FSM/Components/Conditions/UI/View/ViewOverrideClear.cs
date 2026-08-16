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
public class ViewOverrideClear : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewOverrideClear);

    [JsonPropertyName("clearViewIDs_")]
    public BindingList<string> ClearViewIDs { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;
}
