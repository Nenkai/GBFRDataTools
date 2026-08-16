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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotTornadoMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotTornadoMoveAction);

    [JsonPropertyName("isMoveDirIsParentRot_")]
    public bool IsMoveDirIsParentRot { get; set; } = true;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.2f;

    [JsonPropertyName("moveRotY_")]
    public float MoveRotY { get; set; } = 0f;
}
