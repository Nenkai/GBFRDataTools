using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class LobbyListMode : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LobbyListMode);

    [JsonPropertyName("mode_")]
    public EnumString<LobbyListModeEnum> Mode { get; set; } // Offset 0x38

    public LobbyListMode()
    {
    }
}

public enum LobbyListModeEnum
{
    Condition = 0,
    PlayerList = 1,
    PartyID = 2,
}