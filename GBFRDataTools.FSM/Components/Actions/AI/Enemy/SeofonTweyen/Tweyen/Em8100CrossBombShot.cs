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
public class Em8100CrossBombShot : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100CrossBombShot);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "";

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "cross_shot";

    [JsonPropertyName("shotFsmNamePowup_")]
    public string ShotFsmNamePowup { get; set; } = "cross_shot";

    [JsonPropertyName("shotIntervalFrame_")]
    public int ShotIntervalFrame { get; set; } = 15;

    [JsonPropertyName("attackEndWaitTimeSec_")]
    public float AttackEndWaitTimeSec { get; set; } = 1f;

    [JsonPropertyName("attackSignTimeSec_")]
    public float AttackSignTimeSec { get; set; } = 1f;

    [JsonPropertyName("attackSignSize_")]
    public float AttackSignSize { get; set; } = 1.5f;

    [JsonPropertyName("bigArrowHeight_")]
    public float BigArrowHeight { get; set; } = 2f;

    [JsonPropertyName("shotIntervalDistance_")]
    public float ShotIntervalDistance { get; set; } = 10f;
}