using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100CombinationSpecialArtsFinishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100CombinationSpecialArtsFinishAction);

    [JsonPropertyName("fallAnimMovementRate_")]
    public float FallAnimMovementRate { get; set; } = 2.5f;

    [JsonPropertyName("moveLoopTimeSec_")]
    public float MoveLoopTimeSec { get; set; } = 0.8f;

    [JsonPropertyName("finishAttackParamList_")]
    public BindingList<FinishAttackParam> FinishAttackParamList { get; set; } = [.. Enumerable.Repeat(new FinishAttackParam(), 3)]; // std::array<BT::Em8100CombinationSpecialArtsFinishAction::FinishAttackParam,3>

    [JsonPropertyName("wallShotAttackTime_")]
    public float WallShotAttackTime { get; set; } = 3f;

    [JsonPropertyName("wallShotOffsetDist_")]
    public float WallShotOffsetDist { get; set; } = 20f;

    [JsonPropertyName("isCorroMagnificoEnd_")]
    public bool IsCorroMagnificoEnd { get; set; } = false;

    [JsonPropertyName("corroMagnificoWaitTime_")]
    public float CorroMagnificoWaitTime { get; set; } = 8f;

    public class FinishAttackParam /* Em8100CombinationSpecialArtsFinishAction::FinishAttackParam */
    {
        [JsonPropertyName("attackTimeSec_")]
        public float AttackTimeSec { get; set; }
    
        [JsonPropertyName("playerSearchTimeSec_")]
        public float PlayerSearchTimeSec { get; set; }
    
        [JsonPropertyName("rapidFrame_")]
        public int RapidFrame { get; set; }
    
        [JsonPropertyName("endDelayTimeSec_")]
        public float EndDelayTimeSec { get; set; }
    }
}