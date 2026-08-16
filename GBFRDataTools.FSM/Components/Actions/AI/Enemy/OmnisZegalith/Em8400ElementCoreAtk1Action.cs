using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreAtk1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreAtk1Action);

    [JsonPropertyName("isUseMotion_")]
    public bool IsUseMotion { get; set; } = false;

    [JsonPropertyName("isUseLoopMotion_")]
    public bool IsUseLoopMotion { get; set; } = false;

    [JsonPropertyName("isCancelMotion_")]
    public bool IsCancelMotion { get; set; } = false;

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("loopMotionIdName_")]
    public string LoopMotionIdName { get; set; }

    [JsonPropertyName("endMotionIdName_")]
    public string EndMotionIdName { get; set; }

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 1f;

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 1f;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1f;

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f;

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0;
}
