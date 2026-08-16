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
public class Em8400ElementCoreCreateShotStageRandomAction : Em8400ElementCoreCreateShotBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreCreateShotStageRandomAction);

    [JsonPropertyName("shotSlot_")]
    public int ShotSlot { get; set; } = 0;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0f;

    [JsonPropertyName("shotTime_")]
    public float ShotTime { get; set; } = 5f;

    [JsonPropertyName("createInterval_")]
    public float CreateInterval { get; set; } = 0.5f;

    [JsonPropertyName("playerTargetShotCount_")]
    public int PlayerTargetShotCount { get; set; } = 4;

    [JsonPropertyName("multiShotNum_")]
    public int MultiShotNum { get; set; } = 1;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("rot_")]
    public Vector4 Rot { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isTargetPosShot_")]
    public bool IsTargetPosShot { get; set; } = false;

    [JsonPropertyName("isUseOwnerPos_")]
    public bool IsUseOwnerPos { get; set; } = true;

    [JsonPropertyName("isUseOwnerRotY_")]
    public bool IsUseOwnerRotY { get; set; } = true;

    [JsonPropertyName("targetPosShotStartOffset_")]
    public Vector4 TargetPosShotStartOffset { get; set; } = Vector4.UnitW;
}