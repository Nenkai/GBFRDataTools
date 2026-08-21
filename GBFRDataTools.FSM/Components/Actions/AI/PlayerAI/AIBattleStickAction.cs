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
    public bool IsUseBlackBoardValue { get; set; } = false;

    [JsonPropertyName("boolName_")]
    public string? BoolName { get; set; }

    public enum StickType_
    {
        Type0 = 0,
        Type1 = 1,
    }

    public override string? GetCaption()
    {
        string str = $"StickType: {StickType} & ";
        if (IsUseBlackBoardValue)
            str += $"Dir = {BoolName}";
        else
            str += $"Dir = {StickDir:F2}";
        str += $" for {ActiveTime:F2}s)";

        return str;
    }
}
