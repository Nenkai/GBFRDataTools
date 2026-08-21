using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class EmAhrimanSmallBaseTauntAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseTauntAttackAction);

    [JsonPropertyName("landingLoopSec_")]
    public float LandingLoopSec { get; set; } = 1f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("lookDegOffset_")]
    public float LookDegOffset { get; set; } = 0f; 

    [JsonPropertyName("isUseLaser_")]
    public bool IsUseLaser { get; set; } = false; 

    [JsonPropertyName("isChangeNewMotion_")]
    public bool IsChangeNewMotion { get; set; } = false; 

    [JsonPropertyName("tailAttackMoveRate_")]
    public float TailAttackMoveRate { get; set; } = 1f; 

    [JsonPropertyName("searchTargetsDist_")]
    public float SearchTargetsDist { get; set; } = 5f; 

    [JsonPropertyName("firstTailAttackCancelSec_")]
    public float FirstTailAttackCancelSec { get; set; } = -1f; 

    [JsonPropertyName("shotLaserLoopSec_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float ShotLaserLoopSec { get; set; }

    [JsonPropertyName("useShotLaserDamageStack_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float UseShotLaserDamageStack { get; set; }

    [JsonPropertyName("shotLaserMax_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float ShotLaserMax { get; set; }
}
