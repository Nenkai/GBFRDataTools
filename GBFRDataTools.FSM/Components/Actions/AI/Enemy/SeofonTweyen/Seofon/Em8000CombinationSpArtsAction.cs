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
public class Em8000CombinationSpArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000CombinationSpArtsAction);

    [JsonPropertyName("jumpPowerY_")]
    public float JumpPowerY { get; set; } = 2f;

    [JsonPropertyName("moveTypeCheckCloseDist_")]
    public float MoveTypeCheckCloseDist { get; set; } = 4f;

    [JsonPropertyName("moveTypeCheckFarDist_")]
    public float MoveTypeCheckFarDist { get; set; } = 7f;

    [JsonPropertyName("backStepAnimMovetRate_")]
    public float BackStepAnimMovetRate { get; set; } = 0.5f;
}

