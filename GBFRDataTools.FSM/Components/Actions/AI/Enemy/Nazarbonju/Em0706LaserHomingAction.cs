using GBFRDataTools.Entities;
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

public class Em0706LaserHomingAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706LaserHomingAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("homingShotAngleSpd_")]
    public float HomingShotAngleSpd { get; set; } = 0.03f;

    [JsonPropertyName("chaosHomingShotAngleSpd_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float ChaosHomingShotAngleSpd { get; set; } = 0.06f;

    [JsonPropertyName("homingAngleMax_")]
    public Vector2 HomingAngleMax { get; set; } = new Vector2(0.35f, 0.9f);

    [JsonPropertyName("chaosHomingAngleMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public Vector2 ChaosHomingAngleMax { get; set; } = new Vector2(0.35f, 1.5f);

    [JsonPropertyName("homingWaitSec_")]
    public float HomingWaitSec { get; set; } = 2f;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } = new();

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f;

    [JsonPropertyName("chaosFlyHeightMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float ChaosFlyHeightMax { get; set; } = 0f;

    [JsonPropertyName("laserLoopSec_")]
    public float LaserLoopSec { get; set; } = 10f; 

    [JsonPropertyName("laserNotHitSec_")]
    public float LaserNotHitSec { get; set; } = 5f; 

    [JsonPropertyName("isHomingFrozenTarget_")]
    public bool IsHomingFrozenTarget { get; set; } = false;

    [JsonPropertyName("chaosOmenMotSpeed_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float ChaosOmenMotSpeed { get; set; } = 1.3f;

    [JsonPropertyName("openFlyParam_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool OpenFlyParam { get; set; }
}