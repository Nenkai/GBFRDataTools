using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class SetPauseMenuOpenFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPauseMenuOpenFlag);

    [JsonPropertyName("btnType_")]
    public EnumString<SetPauseMenuOpenFlagBtnType> BtnType { get; set; } // Offset 0x30
}

public enum SetPauseMenuOpenFlagBtnType
{
    GoToFateEpisode = 11,
    GoToChapterSelect = 12,
}