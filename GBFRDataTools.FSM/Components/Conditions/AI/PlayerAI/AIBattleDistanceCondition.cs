using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

[Description("Returns whether the AI satisfies a distance condition to the specified object.")]
public class AIBattleDistanceCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleDistanceCondition);

    [JsonPropertyName("distance_")]
    [Description("""
        Distance to check.
        IGNORED if UseBlackBoardValue is specified.
        """)]
    public float Distance { get; set; } = 1.0f;

    [JsonPropertyName("type_")]
    [Description("Type of value to check against.")]
    public AIBattleDistanceConditionType Type { get; set; } = AIBattleDistanceConditionType.Type0;

    [JsonPropertyName("useBlackBoardValue_")]
    [Description("Whether to use a blackboard variable as the distance. OVERRIDES Distance.")]
    public bool UseBlackBoardValue { get; set; } = false;

    [JsonPropertyName("boolName_")]
    [Description("Variable to use as distance, when UseBlackBoardValue is enabled.")]
    public string BoolName { get; set; }
}

public enum AIBattleDistanceConditionType
{
    // Same as AIBattleDistanceCondition except 3 and 4
    /// <summary>
    /// Blackboard Hash: 9C6F9CC6
    /// </summary>
    Type0 = 0,

    /// <summary>
    /// Blackboard Hash: 36F3DAE8
    /// </summary>
    TargetCenter = 1,

    /// <summary>
    /// Blackboard Hash: 0F30C058
    /// </summary>
    Type2 = 2
}
