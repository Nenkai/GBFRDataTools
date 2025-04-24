using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002MoveToAction);

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x38

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 0.01f; // Offset 0x3C

    public Em0002MoveToAction()
    {
    }
}
