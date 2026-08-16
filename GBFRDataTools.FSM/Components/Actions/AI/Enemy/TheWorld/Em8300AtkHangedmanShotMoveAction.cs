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
public class Em8300AtkHangedmanShotMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkHangedmanShotMoveAction);

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = 1f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 1f;

    [JsonPropertyName("isHomingX_")]
    public bool IsHomingX { get; set; } = true;

    [JsonPropertyName("isHomingZ_")]
    public bool IsHomingZ { get; set; } = true;
}