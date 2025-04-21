using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Battle;

public class ShotParentBlackBoardBoolCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotParentBlackBoardBoolCondition);

    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; } = string.Empty;
}
