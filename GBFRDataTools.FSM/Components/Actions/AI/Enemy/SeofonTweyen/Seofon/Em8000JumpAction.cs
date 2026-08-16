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

[Description("Added in Endless Ragnarok")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000JumpAction);

    [JsonPropertyName("jumpPowerXZ_")]
    public float JumpPowerXZ { get; set; } = 0.1f;

    [JsonPropertyName("jumpPowerY_")]
    public float JumpPowerY { get; set; } = 0.1f;
}