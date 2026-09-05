using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em1802ExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802ExAttackAction);
}
