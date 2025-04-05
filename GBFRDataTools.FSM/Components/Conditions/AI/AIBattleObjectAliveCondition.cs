using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

[Description("Returns whether the entity the AI is targetting is alive.")]
public class AIBattleObjectAliveCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleObjectAliveCondition);

    [JsonPropertyName("type_")]
    public AIBattleObjectAliveConditionType Type { get; set; } = AIBattleObjectAliveConditionType.Type0;
}

public enum AIBattleObjectAliveConditionType
{
    /// <summary>
    /// Checks blackboard bool variable: 0x85283F42
    /// </summary>
    Type0 = 0,

    /// <summary>
    /// Checks blackboard bool variable: 0xC7D7747C
    /// </summary>
    Type1 = 1,

    /// <summary>
    /// Checks blackboard bool variable: 0x25D7618D (PlayerAI_IsExistOrderTarget)
    /// </summary>
    PlayerAI_IsExistOrderTarget = 2
}