using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8303SpartsTrialAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303SpartsTrialAction);

    [JsonPropertyName("judgementInterval_")]
    public float JudgementInterval { get; set; } = 0.65f;

    [JsonPropertyName("judgementShotHeight_")]
    public float JudgementShotHeight { get; set; } = 2.5f;

    [JsonPropertyName("judgementShotOffsetDist_")]
    public float JudgementShotOffsetDist { get; set; } = 5f;

    [JsonPropertyName("judgementMaxBreakNum_")]
    public int JudgementMaxBreakNum { get; set; } = 5;

    [JsonPropertyName("judgementRotTime_")]
    public float JudgementRotTime { get; set; } = 0.5f;

    [JsonPropertyName("towerDevilIntervalFirst_")]
    public float TowerDevilIntervalFirst { get; set; } = 3.5f;

    [JsonPropertyName("towerDevilInterval_")]
    public float TowerDevilInterval { get; set; } = 6f;

    [JsonPropertyName("towerDevilAccelTime_")]
    public float TowerDevilAccelTime { get; set; } = 1.5f;

    [JsonPropertyName("towerDevilActiveTime_")]
    public float TowerDevilActiveTime { get; set; } = 4.5f;

    [JsonPropertyName("devilShotInterval_")]
    public float DevilShotInterval { get; set; } = 0.25f;

    [JsonPropertyName("devilShotStopTime_")]
    public float DevilShotStopTime { get; set; } = 1f;

    [JsonPropertyName("devilShotRadius_")]
    public float DevilShotRadius { get; set; } = 5f;

    [JsonPropertyName("devilShotRadiusAdd_")]
    public float DevilShotRadiusAdd { get; set; } = 0.75f;

    [JsonPropertyName("devilShotRotYAdd_")]
    public float DevilShotRotYAdd { get; set; } = 0.12f;

    [JsonPropertyName("devilHomingTimerRate_")]
    public float DevilHomingTimerRate { get; set; } = 0.75f;

    [JsonPropertyName("towerShotInterval_")]
    public float TowerShotInterval { get; set; } = 0.15f;

    [JsonPropertyName("towerShotStopTime_")]
    public float TowerShotStopTime { get; set; } = 1f;

    [JsonPropertyName("towerDevilAccelPushWindSpeed_")]
    public float TowerDevilAccelPushWindSpeed { get; set; } = 4f;

    [JsonPropertyName("towerDevilActivePushWindSpeed_")]
    public float TowerDevilActivePushWindSpeed { get; set; } = 4.5f;

    [JsonPropertyName("towerDevilBaseHeight_")]
    public float TowerDevilBaseHeight { get; set; } = 2.9f;

    [JsonPropertyName("towerDevilActiveHeight_")]
    public float TowerDevilActiveHeight { get; set; } = 5.5f;

    [JsonPropertyName("towerDevilUpDownSpeed_")]
    public float TowerDevilUpDownSpeed { get; set; } = 2.5f;

    [JsonPropertyName("tarotRotSpeedLow_")]
    public float TarotRotSpeedLow { get; set; } = 0.7853982f;

    [JsonPropertyName("tarotRotSpeedHigh_")]
    public float TarotRotSpeedHigh { get; set; } = 12.566371f;
}
