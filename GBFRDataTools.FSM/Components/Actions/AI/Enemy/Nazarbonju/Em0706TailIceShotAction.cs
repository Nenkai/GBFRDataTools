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
    public bool IsHeightMove { get; set; } = false; 

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } = new();

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("actionType_")]
    public int ActionType { get; set; } = 0; 

    [JsonPropertyName("motionMoveRate_")]
    public Vector4 MotionMoveRate { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("iceShotFloatingTimeBase_")]
    public float IceShotFloatingTimeBase { get; set; } = 1f; 

    [JsonPropertyName("iceShotFloatingTimeAdd_")]
    public float IceShotFloatingTimeAdd { get; set; } = 1f; 

    [JsonPropertyName("iceShotCreateNum_")]
    public int IceShotCreateNum { get; set; } = 5; 

    [JsonPropertyName("isPlayComboEffect_")]
    public bool IsPlayComboEffect { get; set; } = false; 

    [JsonPropertyName("comboEffectId_")]
    public int ComboEffectId { get; set; } = -1; 

    [JsonPropertyName("motionInterTime_")]
    public float MotionInterTime { get; set; } = -1f; 

    [JsonPropertyName("isSetStartFlyPos_")]
    public bool IsSetStartFlyPos { get; set; } = false; 

    [JsonPropertyName("startFlyHeight_")]
    public float StartFlyHeight { get; set; } = 1f; 
}