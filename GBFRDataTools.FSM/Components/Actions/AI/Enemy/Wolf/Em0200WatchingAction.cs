using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200WatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200WatchingAction);

    [JsonPropertyName("motionType_")]
    public int MotionType { get; set; } = 0; // Offset 0x44

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.2f; // Offset 0x48

    [JsonPropertyName("playSec_")]
    public float PlaySec { get; set; } = 0f; // Offset 0x4C

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = -1f; // Offset 0x50

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 20f; // Offset 0x54

    [JsonPropertyName("stopCheckLength_")]
    public float StopCheckLength { get; set; } = 5f; // Offset 0x58

    public Em0200WatchingAction()
    {
    }
}
