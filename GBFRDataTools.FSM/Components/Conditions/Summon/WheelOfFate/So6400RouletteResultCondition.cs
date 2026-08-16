using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Summon.WheelOfFate;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So6400RouletteResultCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6400RouletteResultCondition);

    [JsonPropertyName("checkResult_")]
    public int CheckResult { get; set; } = 0;
}
