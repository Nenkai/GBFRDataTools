using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmAlphaAction : ActionComponent
{
    [JsonPropertyName("isOwnerObjId_")]
    public bool IsOwnerObjId { get; set; } = false;

    [JsonPropertyName("isCtrlExtensionAlphaStatus_")]
    public bool IsCtrlExtensionAlphaStatus { get; set; } = true;

    [JsonPropertyName("isActionEndAllEnable_")]
    public bool IsActionEndAllEnable { get; set; } = false;

    [JsonPropertyName("alphaSec_")]
    public float AlphaSec { get; set; } = 1.0f;

    [JsonPropertyName("startAlphaRate_")]
    public float StartAlphaRate { get; set; } = 0.0f;

    [JsonPropertyName("endAlphaRate_")]
    public float EndAlphaRate { get; set; } = 1.0f;

    [JsonPropertyName("alphaEffectObjId_")]
    public int AlphaEffectObjId { get; set; } = -1;

    [JsonPropertyName("alphaEffectId_")]
    public int AlphaEffectId { get; set; } = -1;

    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; } = 0.0f;

    [JsonPropertyName("delayRandomAddSec_")]
    public float DelayRandomAddSec { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = -1;

    [JsonPropertyName("isActionEnd_")]
    public bool IsActionEnd { get; set; } = true;

    [JsonPropertyName("isSyncWeaponAlpha_")]
    public bool IsSyncWeaponAlpha { get; set; }

    [JsonPropertyName("isDeadExDamageAndLockOnEnableCancel_")]
    public bool IsDeadExDamageAndLockOnEnableCancel { get; set; } = true;
}
