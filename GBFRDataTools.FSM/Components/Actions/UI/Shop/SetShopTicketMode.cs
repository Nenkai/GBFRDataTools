using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class SetShopTicketMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetShopTicketMode);

    [JsonPropertyName("mode_")]
    public EnumString<SetShopTicketModeEnum> Mode { get; set; } // Offset 0x30

    public SetShopTicketMode()
    {
    }
}

public enum SetShopTicketModeEnum
{
    // 金章チケット = 3
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    GoldChapterTicket = 3,
}
