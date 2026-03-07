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

public class Em0706LaserSwingAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706LaserSwingAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x84

    [JsonPropertyName("laserActionType_")]
    public int LaserActionType { get; set; } = 0; // Offset 0x88

    [JsonPropertyName("motionMoveRate_")]
    public float MotionMoveRate { get; set; } = 0.5f; // Offset 0x8C

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 2300; // Offset 0x90

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 0.5f; // Offset 0x94

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x98

    public Em0706LaserSwingAction()
    {
    }
}