using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseOnlineCommuShortcutDetailMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseOnlineCommuShortcutDetailMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<PauseOnlineCommuShortcutDetailModeEnum> ModeEnum { get; set; } // Offset 0x30

    public PauseOnlineCommuShortcutDetailMode()
    {
    }
}

public enum PauseOnlineCommuShortcutDetailModeEnum
{
    StampMode = 0,
    FixedPhraseMode = 1,
    EmotionMode = 2,
}
