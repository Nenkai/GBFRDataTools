using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetGameMatchUiMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetGameMatchUiMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SetGameMatchUiModeEnum> ModeEnum { get; set; } // Offset 0x30

    public SetGameMatchUiMode()
    {
    }
}

public enum SetGameMatchUiModeEnum
{
    // 受注クエスト = 0
    // 選択中クエスト = 1
    QuestAccepted = 0,
    QuestSelected = 1,
}