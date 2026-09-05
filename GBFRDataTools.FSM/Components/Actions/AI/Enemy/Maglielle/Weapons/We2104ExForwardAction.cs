using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We2104ExForwardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104ExForwardAction);
}