using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleWaitAction : ActionComponent
{
    [JsonPropertyName("frontMoveTime_")]
    public float FrontMoveTime { get; set; } = 1.0f;

    [JsonPropertyName("sideMoveTime_")]
    public float SideMoveTime { get; set; } = 2.5f;

    [JsonPropertyName("type_")]
    public BattleWaitActionType Type { get; set; } = BattleWaitActionType.Type0;

    [JsonPropertyName("moveRandomTimeMin_")]
    public float MoveRandomTimeMin { get; set; } = 0.0f;

    [JsonPropertyName("moveRandomTimeMax_")]
    public float MoveRandomTimeMax { get; set; } = 1.0f;

    [JsonPropertyName("isUseJackMode_")]
    public bool IsUseJackMode { get; set; } = false;

    public enum BattleWaitActionType
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
        Type2 = 2,

        /// <summary>
        /// B5AC0AD6
        /// </summary>
        Type3 = 3,

        /// <summary>
        /// 63C39302
        /// </summary>
        Type4 = 4,
    }
}
