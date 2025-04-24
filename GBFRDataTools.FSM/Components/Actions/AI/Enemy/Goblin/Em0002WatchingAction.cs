using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002WatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002WatchingAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f; // Offset 0x44

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 4f; // Offset 0x48

    [JsonPropertyName("motionType_")]
    public int MotionType { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x4C

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x50

    public Em0002WatchingAction()
    {
    }
}
