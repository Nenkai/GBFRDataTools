using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundTriggerAction : SoundAutoActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundTriggerAction);

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; }

    [JsonPropertyName("loopDelayTime_")]
    public float LoopDelayTime { get; set; }

    [JsonPropertyName("motionFrames_")]
    public BindingList<BindingList<int>> MotionFrames { get; set; }

    [JsonPropertyName("eventNames_")]
    public BindingList<string> EventNames { get; set; }

    [JsonPropertyName("motionNames_")]
    public BindingList<string> MotionNames { get; set; }

    [JsonPropertyName("isEndTrigger_")]
    public bool IsEndTrigger { get; set; }

    [JsonPropertyName("checkFrameRange_")]
    public int CheckFrameRange { get; set; } = 9999;
}