using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckNetworkConnection : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckNetworkConnection);

    [JsonPropertyName("preset_")]
    public EnumString<CheckNetworkConnectionType> Preset { get; set; }

    [JsonPropertyName("title_")]
    public bool Title { get; set; } = false;

    [JsonPropertyName("isOnlineCheck_")]
    public bool IsOnlineCheck { get; set; } = false;

    [JsonPropertyName("isIgnoreError_")]
    public bool IsIgnoreError { get; set; } = false;

    [JsonPropertyName("isPreNetworkCheck_")]
    public bool IsPreNetworkCheck { get; set; } = false;

    public enum CheckNetworkConnectionType
    {
        TITLE_PRESET = 0,
        PLAYERLIST_SIGNIN_PRESET = 1,
        MULTIPLAY_PRESET = 2,
        Type3 = 3,
        SIGNIN_PRESET = 4,
        NEWS_PRESET = 5,
        NEWS_OPEN_WEB_PRESET = 6,
        GHOST_PRESET = 7,
        WEB_SOCKET_PRESET = 8,
        ONLINE_WITHOUT_PLAYFAB_PRESET = 9,
    }
}

