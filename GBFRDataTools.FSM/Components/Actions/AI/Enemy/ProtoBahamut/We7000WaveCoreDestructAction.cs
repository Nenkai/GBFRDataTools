using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We7000WaveCoreDestructAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7000WaveCoreDestructAction);
}