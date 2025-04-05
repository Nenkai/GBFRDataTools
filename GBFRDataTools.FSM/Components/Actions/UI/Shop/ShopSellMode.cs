using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopSellMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShopSellMode);

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } = new();
}
