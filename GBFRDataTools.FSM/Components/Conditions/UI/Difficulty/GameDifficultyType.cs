using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Difficulty;

public class GameDifficultyType : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GameDifficultyType);

    [JsonPropertyName("difficulty_")]
    public EnumString<GameDifficultyTypeEnum> Difficulty { get; set; } // Offset 0x38

    public GameDifficultyType()
    {
    }
}

public enum GameDifficultyTypeEnum
{
    EASY = 0,
    ACTION = 1,
    HARD = 2,
    ULTIMATE = 3,
}
