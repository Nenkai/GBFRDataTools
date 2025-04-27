using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkRushComboFinish1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkRushComboFinish1Action);

    [JsonPropertyName("startBgEffectTime_")]
    public float StartBgEffectTime { get; set; } = 0f; // Offset 0x88

    [JsonPropertyName("slashTime_")]
    public float SlashTime { get; set; } = 3f; // Offset 0x8C

    [JsonPropertyName("slashFinishWaitTime_")]
    public float SlashFinishWaitTime { get; set; } = 1f; // Offset 0x90

    [JsonPropertyName("hlType_")]
    public int HlType { get; set; } = 0; // Offset 0x94

    public Em7700AtkRushComboFinish1Action()
    {
    }
}


