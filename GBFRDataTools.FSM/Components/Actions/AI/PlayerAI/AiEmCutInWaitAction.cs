using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Player;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AiEmCutInWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEmCutInWaitAction);
}
