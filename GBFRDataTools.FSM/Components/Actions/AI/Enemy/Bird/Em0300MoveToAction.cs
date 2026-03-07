using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300MoveToAction);

    [JsonPropertyName("customFlyParam_")]
    public bool CustomFlyParam { get; set; } = false; // Offset 0x50

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x58

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x78

    [JsonPropertyName("distanceXZ_")]
    public float DistanceXZ { get; set; } = 2f; // Offset 0x7C

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 1f; // Offset 0x80

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x84

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x88

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = true; // Offset 0x8C

    public Em0300MoveToAction()
    {
    }
}
