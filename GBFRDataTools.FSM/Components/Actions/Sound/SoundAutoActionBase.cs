using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundAutoActionBase : ActionComponent
{
    [Obsolete("Not read by the game")]
    [JsonPropertyName("eventName_")]
    public string EventName { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("autoParams_")]
    public BindingList<EventParamUnused> AutoParams { get; set; }

    [JsonPropertyName("eventParam_")]
    public BindingList<EventParam> EventParam { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("nameType_")]
    public int NameType { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; }

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; }

    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; }

    [JsonPropertyName("randomAddCoolTime_")]
    public float RandomAddCoolTime { get; set; }
}

public class EventParam
{
    [JsonPropertyName("eventName_")]
    public string EventName { get; set; }

    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; }

    [JsonPropertyName("requestId_")]
    public uint RequestId { get; set; }

    [JsonPropertyName("isEndCancel_")]
    public bool IsEndCancel { get; set; }

    [JsonPropertyName("isDisable_")]
    public bool IsDisable { get; set; }

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [JsonPropertyName("useSocket_")]
    public bool UseSocket { get; set; }

    [JsonPropertyName("nameType_")]
    public int NameType { get; set; }

    [JsonPropertyName("isCollisionAttribute_")]
    public bool IsCollisionAttribute { get; set; }

    [JsonPropertyName("isEnableOcclusion_")]
    public bool IsEnableOcclusion { get; set; }

    [JsonPropertyName("isEnableMusicSync_")]
    public bool IsEnableMusicSync { get; set; }

    [JsonPropertyName("useWeaponId_")]
    public int UseWeaponId { get; set; }
}

public class EventParamUnused
{
    [JsonPropertyName("eventName_")]
    public string EventName { get; set; }

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [JsonPropertyName("chasePartsNo_")]
    public int ChasePartsNo { get; set; }

    [JsonPropertyName("stopVel_")]
    public float StopVel { get; set; }

    [JsonPropertyName("moveVel_")]
    public float MoveVel { get; set; }

    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; }

    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; }

    [JsonPropertyName("isMoveTrigger_")]
    public bool IsMoveTrigger { get; set; }
}
