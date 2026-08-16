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
public class Em8100TwoCrownsStrifeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100TwoCrownsStrifeAction);

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = -0.06f;

    [JsonPropertyName("actionEndWaitTimeSec_")]
    public float ActionEndWaitTimeSec { get; set; } = 10f;

    [JsonPropertyName("shotBombStartIntervalSec_")]
    public float ShotBombStartIntervalSec { get; set; } = 3f;

    [JsonPropertyName("shotBombIntervalFrame_")]
    public int ShotBombIntervalFrame { get; set; } = 30;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 3;

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "two_crowns_strife_shot";

    [JsonPropertyName("shotPosList_")]
    public BindingList<Vector4> ShotPosList { get; set; } = []; // std::vector<Hw::cVec4>
}