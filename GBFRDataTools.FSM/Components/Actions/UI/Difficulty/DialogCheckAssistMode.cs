using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Difficulty;

[Description("Note: Uses dialog hash 65C87B5D")]
public class DialogCheckAssistMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogCheckAssistMode);

    [JsonPropertyName("mode_")]
    public EnumString<DialogCheckAssistModeEnum> Mode { get; set; } // Offset 0x30
}

public enum DialogCheckAssistModeEnum
{
    Title = 0, // TXT_SYS_TITLE_CHECK_DIFFICULTY/TXT_SYS_TITLE_CHECK_AS_AND_DIF
    GameOver = 1, // TXT_DLG_DIFF_SEL_CHECK/TXT_DLG_DIFF_SEL_ASSI_CHECK
    ChapSelGameOver = 2, // TXT_DLG_DIFF_SEL_CHECK_CHA/TXT_DLG_DIFF_SEL_ASSI_CHECK_CHA
}
