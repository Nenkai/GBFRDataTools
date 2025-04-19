using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Resource;

public class UnloadAsset : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UnloadAsset);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("categories_")]
    public BindingList<EnumString<AssetType>> Categories { get; set; } = [];

    public override string GetCaption()
    {
        return string.Join("\n", Categories.Select(e => Utils.GetEnumDescription(e.Index)));
    }
}
