using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class SetInviteListMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetInviteListMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SetInviteListModeEnum> ModeEnum { get; set; } // Offset 0x30
}

public enum SetInviteListModeEnum
{
    // 招待選択 = 0
    // フォロー解除 = 1
    // 検索 = 2
    InviteSelect = 0,
    Unfollow = 1,
    Search = 2,
}