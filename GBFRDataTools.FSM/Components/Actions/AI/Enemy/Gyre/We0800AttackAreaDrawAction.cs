using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

[Obsolete("Not used by the game")]
public class We0800AttackAreaDrawAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We0800AttackAreaDrawAction);
}