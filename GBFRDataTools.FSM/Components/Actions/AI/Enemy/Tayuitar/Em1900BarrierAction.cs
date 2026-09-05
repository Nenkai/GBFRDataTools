using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em1900BarrierAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900BarrierAction);
}