using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class AIBattleDistanceCondition : ConditionComponent
{
    [JsonPropertyName("distance_")]
    public float Distance { get; set; }

    [JsonPropertyName("type_")]
    public AIBattleDistanceConditionType Type { get; set; }

    [JsonPropertyName("useBlackBoardValue_")]
    public bool UseBlackBoardValue { get; set; }

    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; }
}

public enum AIBattleDistanceConditionType
{
    /// <summary>
    /// 9C6F9CC6
    /// </summary>
    Type0 = 0,

    /// <summary>
    /// 36F3DAE8
    /// </summary>
    Type1 = 1,

    /// <summary>
    /// 0F30C058
    /// </summary>
    Type2 = 2
}
