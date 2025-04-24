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

public class EmAhrimanSmallBaseTailAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseTailAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x40

    [JsonPropertyName("motionMoveRate_")]
    public Vector4 MotionMoveRate { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x50

    public EmAhrimanSmallBaseTailAction()
    {
    }
}
