using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkRushAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkRushAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.5f;

    [JsonPropertyName("isWarpAttack_")]
    public bool IsWarpAttack { get; set; } = false;

    [JsonPropertyName("isDimensionAttack_")]
    public bool IsDimensionAttack { get; set; } = false;
}