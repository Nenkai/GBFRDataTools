using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetTrialBattleDialogMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTrialBattleDialogMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SetTrialBattleDialogModeEnum> ModeEnum { get; set; } // Offset 0x30
}

public enum SetTrialBattleDialogModeEnum
{
    // トライアルバトル = 0,
    // クエスト出発確認 = 1,
    TrialBattle = 0,
    QuestDepartureConfirmation = 1,
}
