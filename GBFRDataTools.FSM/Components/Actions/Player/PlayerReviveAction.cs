using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class PlayerReviveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerReviveAction);

    [JsonPropertyName("healHpValue_")]
    public float HealHpValue { get; set; } = 20f;
}
