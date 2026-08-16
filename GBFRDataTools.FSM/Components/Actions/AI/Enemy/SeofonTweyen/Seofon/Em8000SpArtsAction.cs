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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000SpArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000SpArtsAction);

    [JsonPropertyName("swordGodFinishWaitSec_")]
    public float SwordGodFinishWaitSec { get; set; } = 0f;

    [JsonPropertyName("cutinOffsetRotY_")]
    public float CutinOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("cutinOffsetRotYByHL_")]
    public float CutinOffsetRotYByHL { get; set; } = 0f;
}
