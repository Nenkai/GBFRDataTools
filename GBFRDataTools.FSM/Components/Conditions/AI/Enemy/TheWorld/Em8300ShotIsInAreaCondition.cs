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

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300ShotIsInAreaCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300ShotIsInAreaCondition);

    [JsonPropertyName("centerPos_")]
    public Vector4 CenterPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 0f;
}