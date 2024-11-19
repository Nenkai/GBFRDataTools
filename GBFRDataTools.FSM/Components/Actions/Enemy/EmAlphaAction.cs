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
    public bool IsOwnerObjId { get; set; }

    [JsonPropertyName("isCtrlExtensionAlphaStatus_")]
    public bool IsCtrlExtensionAlphaStatus { get; set; }

    [JsonPropertyName("isActionEndAllEnable_")]
    public bool IsActionEndAllEnable { get; set; }

    [JsonPropertyName("alphaSec_")]
    public float AlphaSec { get; set; }

    [JsonPropertyName("startAlphaRate_")]
    public float StartAlphaRate { get; set; }

    [JsonPropertyName("endAlphaRate_")]
    public float EndAlphaRate { get; set; }

    [JsonPropertyName("alphaEffectObjId_")]
    public int AlphaEffectObjId { get; set; }

    [JsonPropertyName("alphaEffectId_")]
    public int AlphaEffectId { get; set; }

    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; }

    [JsonPropertyName("delayRandomAddSec_")]
    public float DelayRandomAddSec { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; }

    [JsonPropertyName("isActionEnd_")]
    public bool IsActionEnd { get; set; }

    [JsonPropertyName("isSyncWeaponAlpha_")]
    public bool IsSyncWeaponAlpha { get; set; }

    [JsonPropertyName("isDeadExDamageAndLockOnEnableCancel_")]
    public bool IsDeadExDamageAndLockOnEnableCancel { get; set; }
}
