using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Inputs slow left/right movements for a period of time while looking at the enemy the AI is targeting.")]
public class AIBattleWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleWaitAction);

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
        // These variables are set in the following function
        // Sig: 55 41 57 41 56 41 55 41 54 56 57 53 48 81 EC ? ? ? ? 48 8D AC 24 ? ? ? ? C5 78 29 B5 ? ? ? ? C5 78 29 AD ? ? ? ? C5 78 29 A5 ? ? ? ? C5 78 29 9D ? ? ? ? C5 78 29 95 ? ? ? ? C5 78 29 8D ? ? ? ? C5 78 29 85 ? ? ? ? C5 F8 29 BD ? ? ? ? C5 F8 29 B5 ? ? ? ? 48 C7 85 ? ? ? ? ? ? ? ? 48 8B 71

        /// <summary>
        /// Blackboard Hash: 0x9C6F9CC6
        /// </summary>
        Type0 = 0,

        /// <summary>
        /// Blackboard Hash: 0x36F3DAE8
        /// </summary>
        TargetCenter = 1,

        /// <summary>
        /// Blackboard Hash: 0x0F30C058
        /// </summary>
        Type2 = 2,

        /// <summary>
        /// Blackboard Hash: 0xB5AC0AD6 (PlayerAI_OrderTargetDistance)
        /// </summary>
        PlayerAI_OrderTargetDistance = 3,

        /// <summary>
        /// Blackboard Hash: 0x63C39302
        /// </summary>
        Type4 = 4,
    }
}
