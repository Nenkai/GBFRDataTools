using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundRayHitTriggerAction : SoundAutoActionBase
{
    [JsonPropertyName("rayPartsNo_")]
    public int RayPartsNo { get; set; } = -1;

    [JsonPropertyName("rayLength_")]
    public float RayLength { get; set; } = 1.0f;

    [JsonPropertyName("rayDirectionType_")]
    public int RayDirectionType { get; set; } = 0;

    [JsonPropertyName("manualRotDeg_")]
    public /* cVec4 */ Vector4 ManualRotDeg { get; set; } = Vector4.UnitW;

    [JsonPropertyName("startObjDirRotDeg_")]
    public /* cVec4 */ Vector4 StartObjDirRotDeg { get; set; } = Vector4.UnitW;

    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; } = 0.0f;

    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; } = 0;

    [JsonPropertyName("updateObjectDirectionSpeed_")]
    public float UpdateObjectDirectionSpeed { get; set; } = 0.0f;

    [JsonPropertyName("objDirInterTime_")]
    public float ObjDirInterTime { get; set; } = 0.1f;

    [JsonPropertyName("isHitTrigger_")]
    public bool IsHitTrigger { get; set; } = true;
}