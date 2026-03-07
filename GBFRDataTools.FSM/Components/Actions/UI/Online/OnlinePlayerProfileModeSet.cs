using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class OnlinePlayerProfileModeSet : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnlinePlayerProfileModeSet);

    [JsonPropertyName("modeEnum_")]
    public EnumString<OnlinePlayerProfileModeSetEnum> ModeEnum { get; set; } // Offset 0x30

    public OnlinePlayerProfileModeSet()
    {
    }
}

public enum OnlinePlayerProfileModeSetEnum
{
    Type0 = 0,
    Type1 = 1,
    ONLINE_TOP = 2,
    ONLINE_PLAYER_LIST = 3,
    ONLINE_PROFILE_EDIT = 4,
    Type5 = 5,
    INTERACT = 6,
}

