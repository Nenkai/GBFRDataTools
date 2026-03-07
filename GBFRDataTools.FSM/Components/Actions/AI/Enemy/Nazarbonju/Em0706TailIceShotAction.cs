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

public class Em0706TailIceShotAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706TailIceShotAction);

    [JsonPropertyName("isHeightMove_")]
    public bool IsHeightMove { get; set; } = false; // Offset 0x70

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f; // Offset 0x98

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x78

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0xA0

    [JsonPropertyName("actionType_")]
    public int ActionType { get; set; } = 0; // Offset 0x9C

    [JsonPropertyName("motionMoveRate_")]
    public Vector4 MotionMoveRate { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xB0

    [JsonPropertyName("iceShotFloatingTimeBase_")]
    public float IceShotFloatingTimeBase { get; set; } = 1f; // Offset 0xC0

    [JsonPropertyName("iceShotFloatingTimeAdd_")]
    public float IceShotFloatingTimeAdd { get; set; } = 1f; // Offset 0xC4

    [JsonPropertyName("iceShotCreateNum_")]
    public int IceShotCreateNum { get; set; } = 5; // Offset 0xC8

    [JsonPropertyName("isPlayComboEffect_")]
    public bool IsPlayComboEffect { get; set; } = false; // Offset 0xCC

    [JsonPropertyName("comboEffectId_")]
    public int ComboEffectId { get; set; } = -1; // Offset 0xD0

    [JsonPropertyName("motionInterTime_")]
    public float MotionInterTime { get; set; } = -1f; // Offset 0xD4

    [JsonPropertyName("isSetStartFlyPos_")]
    public bool IsSetStartFlyPos { get; set; } = false; // Offset 0xD8

    [JsonPropertyName("startFlyHeight_")]
    public float StartFlyHeight { get; set; } = 1f; // Offset 0xDC

    public Em0706TailIceShotAction()
    {
    }
}