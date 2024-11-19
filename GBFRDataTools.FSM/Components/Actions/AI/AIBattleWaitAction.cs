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
    public float FrontMoveTime { get; set; }

    [JsonPropertyName("sideMoveTime_")]
    public float SideMoveTime { get; set; }

    [JsonPropertyName("type_")]
    public BattleWaitActionType Type { get; set; }

    [JsonPropertyName("moveRandomTimeMin_")]
    public float MoveRandomTimeMin { get; set; }

    [JsonPropertyName("moveRandomTimeMax_")]
    public float MoveRandomTimeMax { get; set; }

    [JsonPropertyName("isUseJackMode_")]
    public bool IsUseJackMode { get; set; }

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
