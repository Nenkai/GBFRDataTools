using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004WatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004WatchingAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 4f; // Offset 0x44

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 4f; // Offset 0x48

    [JsonPropertyName("motionType_")]
    public int MotionType { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 4f; // Offset 0x4C

    public Em0004WatchingAction()
    {
    }
}
