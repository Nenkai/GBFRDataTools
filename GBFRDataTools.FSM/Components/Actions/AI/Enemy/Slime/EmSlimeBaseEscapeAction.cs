using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Slime;

public class EmSlimeBaseEscapeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSlimeBaseEscapeAction);

    [JsonPropertyName("isFastEscape_")]
    public bool IsFastEscape { get; set; } = false; // Offset 0x44

    [JsonPropertyName("escapeTimeSecMax_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float EscapeTimeSecMax { get; set; }

    [JsonPropertyName("escapeTimeSecMin_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float EscapeTimeSecMin { get; set; }

    [JsonPropertyName("escapeTimeSecDecreaseNum_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float EscapeTimeSecDecreaseNum { get; set; }

    public EmSlimeBaseEscapeAction()
    {
    }
}
