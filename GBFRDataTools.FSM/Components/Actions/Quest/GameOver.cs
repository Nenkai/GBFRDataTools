using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class GameOver : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GameOver);

    [JsonPropertyName("gameOverType_")]
    public int GameOverType { get; set; }

    public override string? GetCaption()
    {
        return $"GameOverType: {GameOverType}";
    }
}
