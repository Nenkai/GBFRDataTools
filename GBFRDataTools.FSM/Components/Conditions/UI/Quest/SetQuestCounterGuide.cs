using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Quest;

public class SetQuestCounterGuide : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetQuestCounterGuide);

    [JsonPropertyName("mode_")]
    public EnumString<SetQuestCounterGuideMode> Mode { get; set; } // Offset 0x30

    public SetQuestCounterGuide()
    {
    }
}

public enum SetQuestCounterGuideMode
{
    IslandSelectionScreen = 0, // 島選択画面
    IslandSelectionScreen_IslandSelection = 1, // 島選択画面_島選択
    QuestList = 2, // クエストリスト
}
