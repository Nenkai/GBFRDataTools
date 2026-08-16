using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100LinkLaunchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100LinkLaunchAction);

    [JsonPropertyName("targetPosOffsetDist_")]
    public float TargetPosOffsetDist { get; set; } = 2f;

    [JsonPropertyName("targetPosHeightOffset_")]
    [Obsolete("Not exposed by executable")]
    public float TargetPosHeightOffset { get; set; }

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "2400";

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "link_attack_launch_shot";

    [JsonPropertyName("attackSignFrame_")]
    public int AttackSignFrame { get; set; } = 40;

    [JsonPropertyName("targetPosAdjustStartDistance_")]
    public float TargetPosAdjustStartDistance { get; set; } = 20f;
}