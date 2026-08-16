using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Motion;

[GameSupport(GameVersion.EndlessRagnarok)]
public class MotionStopAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionStopAction);

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = 0f;
}
