using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.FinishCamera;

public class FinishCameraParameterInfo
{
    [JsonPropertyName("targetPartsNo_")]
    public int TargetPartsNo { get; set; }

    [JsonPropertyName("targetOffset_")]
    public Vector4 TargetOffset { get; set; }

    [JsonPropertyName("targetRotOffsetY_")]
    public float TargetRotOffsetY { get; set; }

    [JsonPropertyName("bossCameraOffsetY_")]
    public float BossCameraOffsetY { get; set; }

    [JsonPropertyName("distance_")]
    public float Distance { get; set; }

    [JsonPropertyName("productionTime_")]
    public float ProductionTime { get; set; }

    [JsonPropertyName("checkBossCameraPenetration_")]
    public bool CheckBossCameraPenetration { get; set; }

    [JsonPropertyName("execBossCamera_")]
    public bool ExecBossCamera { get; set; }

    [JsonPropertyName("useBossCameraParam_")]
    public bool UseBossCameraParam { get; set; }

    [JsonPropertyName("finishTargetPartsNo_")]
    public int FinishTargetPartsNo { get; set; }

    [JsonPropertyName("finishTargetOffset_")]
    public Vector4 FinishTargetOffset { get; set; }

    [JsonPropertyName("finishTargetRotOffsetY_")]
    public float FinishTargetRotOffsetY { get; set; }

    [JsonPropertyName("finishCameraOffsetY_")]
    public float FinishCameraOffsetY { get; set; }

    [JsonPropertyName("distancePlayer_")]
    public float DistancePlayer { get; set; }

    [JsonPropertyName("finishProductionTime_")]
    public float FinishProductionTime { get; set; }

    [JsonPropertyName("finishSpecifiedAngle_")]
    public float FinishSpecifiedAngle { get; set; }

    [JsonPropertyName("useFinishSpecifiedAngleTarget_")]
    public bool UseFinishSpecifiedAngleTarget { get; set; }

    [JsonPropertyName("ignoreFinishSpecifiedAngleHeight_")]
    public bool IgnoreFinishSpecifiedAngleHeight { get; set; }

    [JsonPropertyName("checkFinishCameraPenetration_")]
    public bool CheckFinishCameraPenetration { get; set; }

    [JsonPropertyName("useFinishCameraParam_")]
    public bool UseFinishCameraParam { get; set; }

    [JsonPropertyName("heroProductionTime_")]
    public float HeroProductionTime { get; set; }

    [JsonPropertyName("useHeroCameraParam_")]
    public bool UseHeroCameraParam { get; set; }

    [JsonPropertyName("excavallionTargetPartsNo_")]
    public int ExcavallionTargetPartsNo { get; set; }

    [JsonPropertyName("excavallionTargetOffset_")]
    public Vector4 ExcavallionTargetOffset { get; set; }

    [JsonPropertyName("excavallionCameraDistance_")]
    public float ExcavallionCameraDistance { get; set; }

    [JsonPropertyName("excavallionCameraLowAngle_")]
    public float ExcavallionCameraLowAngle { get; set; }

    [JsonPropertyName("excavallionProductionTime_")]
    public float ExcavallionProductionTime { get; set; }

    [JsonPropertyName("useExcavallionCameraParam_")]
    public bool UseExcavallionCameraParam { get; set; }
}
