using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class OpenItemDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenItemDialog);

    [JsonPropertyName("mode_")]
    public EnumString<OpenItemDialogMode> Mode { get; set; } = new();
}

public enum OpenItemDialogMode
{
    ShopChara = 1,
    ShopTrade = 2,
    Appraiser = 3,
    ShopTicket = 5,
    BadgeRewardItem = 6,
    ShopCharaStamp = 7,
}