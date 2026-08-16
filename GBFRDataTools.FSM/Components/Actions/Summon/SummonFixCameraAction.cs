using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonFixCameraAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonFixCameraAction);

    [JsonPropertyName("isUseCameraOffset_")]
    public bool IsUseCameraOffset { get; set; } = false;

    [JsonPropertyName("isUseFixCameraDegree_")]
    public bool IsUseFixCameraDegree { get; set; } = true;

    [JsonPropertyName("isBasedCameraAngle_")]
    public bool IsBasedCameraAngle { get; set; } = false;

    [JsonPropertyName("isLockOnCameraFixDisable_")]
    public bool IsLockOnCameraFixDisable { get; set; } = false;

    [JsonPropertyName("isFixOnlyX_")]
    public bool IsFixOnlyX { get; set; } = false;

    [JsonPropertyName("isFixOnlyY_")]
    public bool IsFixOnlyY { get; set; } = false;

    [JsonPropertyName("cameraOffsetPos_")]
    public Vector4 CameraOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("cameraOffsetDegree_")]
    public Vector2 CameraOffsetDegree { get; set; } = Vector2.Zero;

    [JsonPropertyName("cameraInterRate_")]
    public float CameraInterRate { get; set; } = 0f;

    [JsonPropertyName("isFixInterRate_")]
    public bool IsFixInterRate { get; set; } = false;
}
