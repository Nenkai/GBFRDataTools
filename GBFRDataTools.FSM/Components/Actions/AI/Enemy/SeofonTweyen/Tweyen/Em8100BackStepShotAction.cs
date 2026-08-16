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
public class Em8100BackStepShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100BackStepShotAction);

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "step_shot_s";

    [JsonPropertyName("followArrowFsmName_")]
    public string FollowArrowFsmName { get; set; } = "option_shot_type_c";

    [JsonPropertyName("wallEdgeDistance_")]
    public float WallEdgeDistance { get; set; } = 12f;

    [JsonPropertyName("attackSignFrame_")]
    public int AttackSignFrame { get; set; } = 35;

    [JsonPropertyName("attackSignWidth_")]
    public float AttackSignWidth { get; set; } = 5f;

    [JsonPropertyName("animMoveRate_")]
    public float AnimMoveRate { get; set; } = 1.5f;

    [JsonPropertyName("attackTargetOffsetLength_")]
    public float AttackTargetOffsetLength { get; set; } = 2f;

    [JsonPropertyName("followArrowOffsetList_")]
    public BindingList<float> FollowArrowOffsetList { get; set; } = []; // std::vector<Hw::cVec4>
}