using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Added in Endless Ragnarok.")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class AIPrepareWeaponAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIPrepareWeaponAction);

    [JsonPropertyName("status_")]
    public int Status { get; set; } = 0;
}
