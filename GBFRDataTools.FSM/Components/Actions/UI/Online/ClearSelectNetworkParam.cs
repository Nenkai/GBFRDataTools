using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class ClearSelectNetworkParam : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearSelectNetworkParam);

    [JsonPropertyName("friendList_")]
    public bool FriendList { get; set; } = false; // Offset 0x30

    [JsonPropertyName("lobbyList_")]
    public bool LobbyList { get; set; } = false; // Offset 0x31

    public ClearSelectNetworkParam()
    {
    }
}