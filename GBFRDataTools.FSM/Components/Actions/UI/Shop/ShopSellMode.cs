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
    public EnumString<ShopSellModeEnum> Mode { get; set; } = new();
}

public enum ShopSellModeEnum
{
    None = 0,
    Geen = 1,
    Pendulum = 2,
    Material = 3,
    CashMaterial = 4,
}