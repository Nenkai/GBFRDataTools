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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7600ExOverAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ExOverAttackAction);

    [JsonPropertyName("fixHomingSec_")]
    public float FixHomingSec { get; set; } = 3f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.3f;

    [JsonPropertyName("maxHomingDegree_")]
    public float MaxHomingDegree { get; set; } = 30f;

    [JsonPropertyName("basePosZ_")]
    public float BasePosZ { get; set; } = 40f;

    [JsonPropertyName("shotSpace_")]
    public float ShotSpace { get; set; } = 20f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.5f;
}