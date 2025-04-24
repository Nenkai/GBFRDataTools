using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004MotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x30

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false; // Offset 0x38

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0.1f; // Offset 0x40

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = -1f; // Offset 0x44

    public Em0004MotionPlayAction()
    {
    }
}
