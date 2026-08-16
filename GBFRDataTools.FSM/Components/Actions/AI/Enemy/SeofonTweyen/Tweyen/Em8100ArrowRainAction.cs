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
public class Em8100ArrowRainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ArrowRainAction);

    [JsonPropertyName("isSearchAttackMode_")]
    public bool IsSearchAttackMode { get; set; } = false;

    [JsonPropertyName("isFollowArrowAttack_")]
    public bool IsFollowArrowAttack { get; set; } = false;

    [JsonPropertyName("isOneShotMotionPlay_")]
    public bool IsOneShotMotionPlay { get; set; } = false;

    [JsonPropertyName("motionLoopSec_")]
    public float MotionLoopSec { get; set; } = 1f;

    [JsonPropertyName("searchAttackCloseLength_")]
    public float SearchAttackCloseLength { get; set; } = 9f;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "arrow_rain";

    [JsonPropertyName("shotParamList_")]
    public BindingList<KillingRainShotParam> ShotParamList { get; set; } = []; // std::vector<BT::Em8100ArrowRainAction::KillingRainShotParam>

    [JsonPropertyName("followArrowShotNum_")]
    public int FollowArrowShotNum { get; set; } = 10;

    [JsonPropertyName("followArrowShotIntervalFrame_")]
    public int FollowArrowShotIntervalFrame { get; set; } = 30;

    public class KillingRainShotParam /* Em8100ArrowRainAction::KillingRainShotParam */
    {
        [JsonPropertyName("isTargetSearch_")]
        public bool IsTargetSearch { get; set; }
    
        [JsonPropertyName("delayTimeSec_")]
        public float DelayTimeSec { get; set; }
    
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; }
    }
}