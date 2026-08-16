using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonSyncMotionBlendRateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSyncMotionBlendRateAction);

    [JsonPropertyName("motionSlotNo_")]
    public int MotionSlotNo { get; set; } = 0;

    [JsonPropertyName("interCompleteSec_")]
    public float InterCompleteSec { get; set; } = 0f;

    [JsonPropertyName("blendRateBBValueName_")]
    public string BlendRateBBValueName { get; set; }

    [JsonPropertyName("reliableUpdateTime_")]
    public float ReliableUpdateTime { get; set; } = 0f;

    [JsonPropertyName("reliableSendCountMax_")]
    public int ReliableSendCountMax { get; set; } = 0;
}
