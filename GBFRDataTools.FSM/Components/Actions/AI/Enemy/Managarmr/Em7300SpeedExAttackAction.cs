using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7300SpeedExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300SpeedExAttackAction);

    [JsonPropertyName("isReverseRot_")]
    public bool IsReverseRot { get; set; } = false;
}

