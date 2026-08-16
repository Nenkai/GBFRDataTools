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
public class SummonCameraRateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCameraRateAction);

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; } = 0f;

    [JsonPropertyName("useNoResultStatus_")]
    public bool UseNoResultStatus { get; set; } = false;
}

