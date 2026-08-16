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
public class Em8100CreateCrossBombSplitShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100CreateCrossBombSplitShotAction);

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "-";

    [JsonPropertyName("splitNum_")]
    public int SplitNum { get; set; } = 4;

    [JsonPropertyName("splitNumPowup_")]
    public int SplitNumPowup { get; set; } = 6;

    [JsonPropertyName("signTimeSec_")]
    public float SignTimeSec { get; set; } = 1f;

    [JsonPropertyName("signOffsetY_")]
    public float SignOffsetY { get; set; } = 0.3f;
}