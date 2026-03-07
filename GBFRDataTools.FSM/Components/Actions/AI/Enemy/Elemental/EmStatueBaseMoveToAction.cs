using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class EmStatueBaseMoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmStatueBaseMoveToAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x38

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x44

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 4f; // Offset 0x3C

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = false; // Offset 0x48

    public EmStatueBaseMoveToAction()
    {
    }
}

