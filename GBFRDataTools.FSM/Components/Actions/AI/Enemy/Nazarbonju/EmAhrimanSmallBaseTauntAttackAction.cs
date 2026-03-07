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
    public float LandingLoopSec { get; set; } = 1f; // Offset 0x74

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x84

    [JsonPropertyName("lookDegOffset_")]
    public float LookDegOffset { get; set; } = 0f; // Offset 0x88

    [JsonPropertyName("isUseLaser_")]
    public bool IsUseLaser { get; set; } = false; // Offset 0x80

    [JsonPropertyName("isChangeNewMotion_")]
    public bool IsChangeNewMotion { get; set; } = false; // Offset 0x81

    [JsonPropertyName("tailAttackMoveRate_")]
    public float TailAttackMoveRate { get; set; } = 1f; // Offset 0x7C

    [JsonPropertyName("searchTargetsDist_")]
    public float SearchTargetsDist { get; set; } = 5f; // Offset 0x70

    [JsonPropertyName("firstTailAttackCancelSec_")]
    public float FirstTailAttackCancelSec { get; set; } = -1f; // Offset 0x78

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

    public EmAhrimanSmallBaseTauntAttackAction()
    {
    }
}
