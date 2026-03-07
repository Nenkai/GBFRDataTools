using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseOnlineMenuSelect : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseOnlineMenuSelect);

    [JsonPropertyName("modeEnum_")]
    public EnumString<PauseOnlineMenuSelectEnum> ModeEnum { get; set; } // Offset 0x30

    public PauseOnlineMenuSelect()
    {
    }
}

public enum PauseOnlineMenuSelectEnum
{
    None = 0,
    PlayerList = 1,
    ProfileEdit = 2,
    CommunicationEdit = 3,
    StatusIconEdit = 4,
}
