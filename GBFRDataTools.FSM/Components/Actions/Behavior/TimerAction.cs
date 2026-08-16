using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[Description("Starts a timer that can be checked using ActionEndCondition")]
public class TimerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TimerAction);

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 0.0f;

    [JsonPropertyName("randomSeconds_")]
    public float RandomSeconds { get; set; } = 0.0f;

    [JsonPropertyName("isUseBlackBoardTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsUseBlackBoardTime { get; set; } = false;

    [JsonPropertyName("bbTimeName_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string BbTimeName { get; set; }

    [JsonPropertyName("bbTimeHashValue_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public uint BbTimeHashValue { get; set; } = 0;

    [JsonPropertyName("isUseBehaviorDeltaTime_")]
    public bool IsUseBehaviorDeltaTime { get; set; } = false;

    [JsonPropertyName("isUseFrameCount_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsUseFrameCount { get; set; } = false; // Offset 0x6D

    [JsonPropertyName("frameCount_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public int FrameCount { get; set; } = 0; // Offset 0x70

    public override string GetCaption()
    {
        if (IsUseFrameCount)
            return $"Wait {FrameCount} frames";

        if  (IsUseBlackBoardTime)
            return $"Wait x seconds from variable {BbTimeName}";

        return $"Wait {WaitTimeSeconds}s";
    }
}
