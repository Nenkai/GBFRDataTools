using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopNpcMotion : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShopNpcMotion);

    [JsonPropertyName("groupName_")]
    public string GroupName { get; set; } = string.Empty;

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("motions_")]
    public BindingList<ShopNpcMotionType> Motions { get; set; } = [];
}

public enum ShopNpcMotionType
{
    // 選択時
    WhenSelected = 0,
}
