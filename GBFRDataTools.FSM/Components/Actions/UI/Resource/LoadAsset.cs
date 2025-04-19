using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Resource;

public class LoadAsset : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LoadAsset);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [Description("Matches categories in asset_load_setting.json.")]
    [JsonPropertyName("categories_")]
    public BindingList<EnumString<AssetType>> Categories { get; set; } = [];
}