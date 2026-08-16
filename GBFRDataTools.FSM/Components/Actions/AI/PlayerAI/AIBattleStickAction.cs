using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Allows moving an AI into any direction (stick movement).")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class AIBattleStickAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleStickAction);

    [JsonPropertyName("stickType_")]
    public StickType_ StickType { get; set; } = 0;

    [JsonPropertyName("stickDir_")]
    public Vector2 StickDir { get; set; } = Vector2.Zero;

    [JsonPropertyName("activeTime_")]
    public float ActiveTime { get; set; } = 0f;

    [JsonPropertyName("isUseBlackBoardValue_")]
    [Description("Whether to use a blackboard variable instead of specified value.")]
    public bool IsUseBlackBoardValue { get; set; } = false;

    [JsonPropertyName("boolName_")]
    [Description("Blackboard variable name")]
    public string BoolName { get; set; }

    public enum StickType_
    {
        Type0 = 0,
        Type1 = 1,
    }
}
