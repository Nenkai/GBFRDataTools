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
public class Em8400MoveEscapeBattleAreaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400MoveEscapeBattleAreaAction);

    [JsonPropertyName("returnPosOffset_")]
    public Vector4 ReturnPosOffset { get; set; } = new Vector4(0f, 50f, 350f, 1f);
}
