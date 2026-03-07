using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004MoveToAction);

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = false; // Offset 0x40

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 0.008f; // Offset 0x44

    public Em0004MoveToAction()
    {
    }
}
