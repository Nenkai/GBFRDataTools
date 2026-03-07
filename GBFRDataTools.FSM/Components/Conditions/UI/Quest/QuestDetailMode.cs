using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Quest;

public class QuestDetailMode : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestDetailMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<QuestDetailModeEnum> ModeEnum { get; set; } // Offset 0x38

    public QuestDetailMode()
    {
    }
}

public enum QuestDetailModeEnum
{
    // 受注 = 0
    // 自分のクエスト確認 = 1
    AcceptingAnOrder = 0,
    CheckYourQuest = 1,
}
