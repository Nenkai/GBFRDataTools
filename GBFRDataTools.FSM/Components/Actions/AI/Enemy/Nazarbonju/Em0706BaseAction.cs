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

public class Em0706CounterAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706CounterAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x90

    [JsonPropertyName("motionMoveRate_")]
    public Vector4 MotionMoveRate { get; set; } = new Vector4(1f, 1f, 1f, 1f); // Offset 0xA0

    [JsonPropertyName("iceShotFloatingTimeBase_")]
    public float IceShotFloatingTimeBase { get; set; } = 1f; // Offset 0xB0

    [JsonPropertyName("iceShotFloatingTimeAdd_")]
    public float IceShotFloatingTimeAdd { get; set; } = 1f; // Offset 0xB4

    [JsonPropertyName("iceShotCreateNum_")]
    public int IceShotCreateNum { get; set; } = 10; // Offset 0xB8

    [JsonPropertyName("iceShotCreateOffset_")]
    public Vector4 IceShotCreateOffset { get; set; } = new Vector4(0f, 7.5f, 5f, 1f); // Offset 0xC0

    [JsonPropertyName("iceShotCustomType_")]
    public int IceShotCustomType { get; set; } = 1; // Offset 0xD0

    [JsonPropertyName("isShotCall_")]
    public bool IsShotCall { get; set; } = true; // Offset 0xD4

    public Em0706CounterAction()
    {
    }
}