using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Difficulty;

public class SetDifficultySelectMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDifficultySelectMode);

    [JsonPropertyName("mode_")]
    public EnumString<SetDifficultySelectModeEnum> Mode { get; set; } // Offset 0x30

    [JsonPropertyName("assistModeType_")]
    public EnumString<AssistModeType> AssistModeType { get; set; } // Offset 0x60
}

public enum SetDifficultySelectModeEnum
{
    Title = 1,
    GameOver = 2,
    AssistMode = 3,
    Matching = 4,
}

public enum AssistModeType
{
    None = 0,
}