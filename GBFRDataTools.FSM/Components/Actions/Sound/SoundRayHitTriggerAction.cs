using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundRayHitTriggerAction : SoundAutoActionBase
{
    [JsonPropertyName("rayPartsNo_")]
    public int RayPartsNo { get; set; }

    [JsonPropertyName("rayLength_")]
    public float RayLength { get; set; }

    [JsonPropertyName("rayDirectionType_")]
    public int RayDirectionType { get; set; }

    [JsonPropertyName("manualRotDeg_")]
    public cVec4 ManualRotDeg { get; set; }

    [JsonPropertyName("startObjDirRotDeg_")]
    public cVec4 StartObjDirRotDeg { get; set; }

    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; }

    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; }

    [JsonPropertyName("updateObjectDirectionSpeed_")]
    public float UpdateObjectDirectionSpeed { get; set; }

    [JsonPropertyName("objDirInterTime_")]
    public float ObjDirInterTime { get; set; }

    [JsonPropertyName("isHitTrigger_")]
    public bool IsHitTrigger { get; set; }
}