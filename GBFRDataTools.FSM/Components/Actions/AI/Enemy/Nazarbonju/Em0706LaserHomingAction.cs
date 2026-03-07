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
    public float HomingAngle { get; set; } = 10f; // Offset 0xE8

    [JsonPropertyName("homingShotAngleSpd_")]
    public float HomingShotAngleSpd { get; set; } = 0.03f; // Offset 0xEC

    [JsonPropertyName("homingAngleMax_")]
    public Vector2 HomingAngleMax { get; set; } = new Vector2(0.35f, 0.9f); // Offset 0xF0

    [JsonPropertyName("homingWaitSec_")]
    public float HomingWaitSec { get; set; } = 2f; // Offset 0x100

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x108

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f; // Offset 0x128

    [JsonPropertyName("laserLoopSec_")]
    public float LaserLoopSec { get; set; } = 10f; // Offset 0x12C

    [JsonPropertyName("laserNotHitSec_")]
    public float LaserNotHitSec { get; set; } = 5f; // Offset 0x130

    [JsonPropertyName("isHomingFrozenTarget_")]
    public bool IsHomingFrozenTarget { get; set; } = false; // Offset 0x134

    [JsonPropertyName("openFlyParam_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool OpenFlyParam { get; set; }

    public Em0706LaserHomingAction()
    {
    }
}