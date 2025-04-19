using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.Shop;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopSellReaffirmation : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShopSellReaffirmation);

    [JsonPropertyName("mode_")]
    public EnumString<IsSellReaffirmationType> Mode { get; set; } // Offset 0x30

    public ShopSellReaffirmation()
    {
    }
}
