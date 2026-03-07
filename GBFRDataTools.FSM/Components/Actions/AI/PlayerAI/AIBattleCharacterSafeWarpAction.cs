using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleCharacterSafeWarpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleCharacterSafeWarpAction);

    public AIBattleCharacterSafeWarpAction()
    {
    }
}
