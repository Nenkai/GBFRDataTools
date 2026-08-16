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
public class Em8100LinkFinishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100LinkFinishAction);

    [JsonPropertyName("motionMovementRate_")]
    public float MotionMovementRate { get; set; } = 2f;

    [JsonPropertyName("movementAdjustmentValue_")]
    public float MovementAdjustmentValue { get; set; } = -4f;

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "link_attack_finish_shot";
}