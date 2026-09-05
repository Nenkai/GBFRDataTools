using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7200ExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200ExAttackAction);

    [JsonPropertyName("isLeftSide_")]
    public bool IsLeftSide { get; set; } = true;
}
