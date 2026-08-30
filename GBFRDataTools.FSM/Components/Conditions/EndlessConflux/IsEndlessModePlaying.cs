using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Conflux;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsEndlessModePlaying : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsEndlessModePlaying);
}
