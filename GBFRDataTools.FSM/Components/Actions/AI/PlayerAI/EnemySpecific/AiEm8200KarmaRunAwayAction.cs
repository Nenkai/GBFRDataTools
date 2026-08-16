using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AiEm8200KarmaRunAwayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm8200KarmaRunAwayAction);
}
