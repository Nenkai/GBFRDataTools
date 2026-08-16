using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Input;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckStickMoveCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckStickMoveCondition);
}