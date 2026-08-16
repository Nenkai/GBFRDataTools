using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed in the executable")]
public class AIEm8000SwordGodComboMoveCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm8000SwordGodComboMoveCondition);

    [JsonPropertyName("conditionType_")]
    public int ConditionType { get; set; }

    [JsonPropertyName("targetDist_")]
    public float TargetDist { get; set; }
}
