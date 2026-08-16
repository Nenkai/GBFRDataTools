using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Albacore;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8500DiveOuterStageAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8500DiveOuterStageAction);
}