using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class EmAhrimanSmallBaseLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseLaserAction);

    [JsonPropertyName("startMotionMoveRate_")]
    public float StartMotionMoveRate { get; set; } = 0.5f; // Offset 0x58

    [JsonPropertyName("laserLoopSec_")]
    public float LaserLoopSec { get; set; } = 1f; // Offset 0x5C

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x54

    [JsonPropertyName("isShowLaserSight_")]
    public bool IsShowLaserSight { get; set; } = true; // Offset 0x60

    [JsonPropertyName("isForceFullCharge_")]
    public bool IsForceFullCharge { get; set; } = false; // Offset 0x61

    public EmAhrimanSmallBaseLaserAction()
    {
    }
}
