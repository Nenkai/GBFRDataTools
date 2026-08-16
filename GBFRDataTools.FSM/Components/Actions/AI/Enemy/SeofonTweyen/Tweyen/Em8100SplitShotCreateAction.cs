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
public class Em8100SplitShotCreateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100SplitShotCreateAction);

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "division_shot";

    [JsonPropertyName("rotYPeternNum_")]
    public int RotYPeternNum { get; set; } = 8;

    [JsonPropertyName("splitNum_")]
    public int SplitNum { get; set; } = 3;

    [JsonPropertyName("shotRotX_")]
    public float ShotRotX { get; set; } = -60f;
}