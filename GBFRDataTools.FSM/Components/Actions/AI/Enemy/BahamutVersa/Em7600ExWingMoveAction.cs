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
public class Em7600ExWingMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ExWingMoveAction);

    [JsonPropertyName("randMoveValue_")]
    public float RandMoveValue { get; set; } = 5.0f;
}
