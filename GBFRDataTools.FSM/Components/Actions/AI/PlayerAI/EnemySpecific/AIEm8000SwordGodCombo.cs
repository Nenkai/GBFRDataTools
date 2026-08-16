using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[Obsolete("Does not exist in executable")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class AIEm8000SwordGodCombo : EmAINpcActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm8000SwordGodCombo);
}
