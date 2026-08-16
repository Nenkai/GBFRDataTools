using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[Obsolete("Not used/exposed by the executable.")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotSplineFallAction : Em8400ElementCoreShotSplineFallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkMovePlasmaAction);
}