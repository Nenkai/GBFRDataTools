using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Scene.Objects;

public class GroundSmokeSceneObject : ISceneObject
{
    [JsonPropertyName("colorTexFilePath_")]
    public string ColorTexFilePath { get; set; }

    [JsonPropertyName("noiseTexFilePath_")]
    public string NoiseTexFilePath { get; set; }

    [JsonPropertyName("noiseMaskTexFilePath_")]
    public string NoiseMaskTexFilePath { get; set; }

    [JsonPropertyName("lifeTimeMax_")]
    public float LifeTimeMax { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("zPush_")]
    public float ZPush { get; set; }

    [JsonPropertyName("billboardSize_")]
    public /* cVec2 */ Vector2 BillboardSize { get; set; }

    [JsonPropertyName("uvScrollAnimationScale_")]
    public float UvScrollAnimationScale { get; set; }

    [JsonPropertyName("noiseR_UvScrollAdd_")]
    public /* cVec2 */ Vector2 NoiseR_UvScrollAdd { get; set; }

    [JsonPropertyName("noiseG_UvScrollAdd_")]
    public /* cVec2 */ Vector2 NoiseG_UvScrollAdd { get; set; }

    [JsonPropertyName("noiseR_UvScrollAddSub_")]
    public /* cVec2 */ Vector2 NoiseR_UvScrollAddSub { get; set; }

    [JsonPropertyName("noiseG_UvScrollAddSub_")]
    public /* cVec2 */ Vector2 NoiseG_UvScrollAddSub { get; set; }

    [JsonPropertyName("noiseR_ChannelUvScale_")]
    public float NoiseR_ChannelUvScale { get; set; }

    [JsonPropertyName("noiseG_ChannelUvScale_")]
    public float NoiseG_ChannelUvScale { get; set; }

    [JsonPropertyName("noiseVec_")]
    public /* cVec2 */ Vector2 NoiseVec { get; set; }

    [JsonPropertyName("color_")]
    public GuiColor Color { get; set; }

    [JsonPropertyName("shadowColor_")]
    public GuiColor ShadowColor { get; set; }

    [JsonPropertyName("depthFade_")]
    public float DepthFade { get; set; }

    [JsonPropertyName("shadowRate_")]
    public float ShadowRate { get; set; }

    [JsonPropertyName("shadowBoke_")]
    public float ShadowBoke { get; set; }

    [JsonPropertyName("shadowDistortionX_")]
    public float ShadowDistortionX { get; set; }

    [JsonPropertyName("shadowDistortionY_")]
    public float ShadowDistortionY { get; set; }

    [JsonPropertyName("distanceFadeMin_")]
    public float DistanceFadeMin { get; set; }

    [JsonPropertyName("distanceFadeMax_")]
    public float DistanceFadeMax { get; set; }

    [JsonPropertyName("createTime_")]
    public float CreateTime { get; set; }

    [JsonPropertyName("createPosOffset_")]
    public /* cVec3 */ Vector3 CreatePosOffset { get; set; }

    [JsonPropertyName("createAreaDistance_")]
    public float CreateAreaDistance { get; set; }

    [JsonPropertyName("createAreaHeight_")]
    public float CreateAreaHeight { get; set; }

    [JsonPropertyName("createAreaStartDistanceRate_")]
    public float CreateAreaStartDistanceRate { get; set; }

    [JsonPropertyName("distanceSizeScaleAreaMinRate_")]
    public float DistanceSizeScaleAreaMinRate { get; set; }

    [JsonPropertyName("distanceSizeScaleMin_")]
    public float DistanceSizeScaleMin { get; set; }

    [JsonPropertyName("distanceSizeScaleMax_")]
    public float DistanceSizeScaleMax { get; set; }

    [JsonPropertyName("distanceUvScrollScaleMin_")]
    public float DistanceUvScrollScaleMin { get; set; }

    [JsonPropertyName("distanceUvScrollScaleMax_")]
    public float DistanceUvScrollScaleMax { get; set; }

    [JsonPropertyName("distanceDepthFadeScaleMin_")]
    public float DistanceDepthFadeScaleMin { get; set; }

    [JsonPropertyName("distanceDepthFadeScaleMax_")]
    public float DistanceDepthFadeScaleMax { get; set; }

    [JsonPropertyName("windPower_")]
    public float WindPower { get; set; }

    [JsonPropertyName("windPowerRate_")]
    public float WindPowerRate { get; set; }

    [JsonPropertyName("windRotY_")]
    public float WindRotY { get; set; }

    [JsonPropertyName("windSystemPowerOffset_")]
    public float WindSystemPowerOffset { get; set; }

    [JsonPropertyName("windSystemRotYOffset_")]
    public float WindSystemRotYOffset { get; set; }

    [JsonPropertyName("dirLightRate_")]
    public float DirLightRate { get; set; }

    [JsonPropertyName("isUseCameraPosEmitter_")]
    public bool IsUseCameraPosEmitter { get; set; }

    [JsonPropertyName("isCreateGroundPos_")]
    public bool IsCreateGroundPos { get; set; }

    [JsonPropertyName("isUseBoxArea_")]
    public bool IsUseBoxArea { get; set; }

    [JsonPropertyName("isUseWindSystem_")]
    public bool IsUseWindSystem { get; set; }

    [JsonPropertyName("isUseShadowBuffer_")]
    public bool IsUseShadowBuffer { get; set; }

    [JsonPropertyName("isUseDirLight_")]
    public bool IsUseDirLight { get; set; }

    [JsonPropertyName("isUseSecondParam_")]
    public bool IsUseSecondParam { get; set; }

    [JsonPropertyName("colorTexFilePath2_")]
    public string ColorTexFilePath2 { get; set; }

    [JsonPropertyName("noiseTexFilePath2_")]
    public string NoiseTexFilePath2 { get; set; }

    [JsonPropertyName("noiseMaskTexFilePath2_")]
    public string NoiseMaskTexFilePath2 { get; set; }

    [JsonPropertyName("lifeTimeMax2_")]
    public float LifeTimeMax2 { get; set; }

    [JsonPropertyName("moveSpeed2_")]
    public float MoveSpeed2 { get; set; }

    [JsonPropertyName("zPush2_")]
    public float ZPush2 { get; set; }

    [JsonPropertyName("billboardSize2_")]
    public /* cVec2 */ Vector2 BillboardSize2 { get; set; }

    [JsonPropertyName("uvScrollAnimationScale2_")]
    public float UvScrollAnimationScale2 { get; set; }

    [JsonPropertyName("noiseR_UvScrollAdd2_")]
    public /* cVec2 */ Vector2 NoiseR_UvScrollAdd2 { get; set; }

    [JsonPropertyName("noiseG_UvScrollAdd2_")]
    public /* cVec2 */ Vector2 NoiseG_UvScrollAdd2 { get; set; }

    [JsonPropertyName("noiseR_UvScrollAddSub2_")]
    public /* cVec2 */ Vector2 NoiseR_UvScrollAddSub2 { get; set; }

    [JsonPropertyName("noiseG_UvScrollAddSub2_")]
    public /* cVec2 */ Vector2 NoiseG_UvScrollAddSub2 { get; set; }

    [JsonPropertyName("noiseR_ChannelUvScale2_")]
    public float NoiseR_ChannelUvScale2 { get; set; }

    [JsonPropertyName("noiseG_ChannelUvScale2_")]
    public float NoiseG_ChannelUvScale2 { get; set; }

    [JsonPropertyName("noiseVec2_")]
    public /* cVec2 */ Vector2 NoiseVec2 { get; set; }

    [JsonPropertyName("color2_")]
    public GuiColor Color2 { get; set; }

    [JsonPropertyName("shadowColor2_")]
    public GuiColor ShadowColor2 { get; set; }

    [JsonPropertyName("depthFade2_")]
    public float DepthFade2 { get; set; }

    [JsonPropertyName("shadowRate2_")]
    public float ShadowRate2 { get; set; }

    [JsonPropertyName("shadowBoke2_")]
    public float ShadowBoke2 { get; set; }

    [JsonPropertyName("shadowDistortionX2_")]
    public float ShadowDistortionX2 { get; set; }

    [JsonPropertyName("shadowDistortionY2_")]
    public float ShadowDistortionY2 { get; set; }

    [JsonPropertyName("distanceFadeMin2_")]
    public float DistanceFadeMin2 { get; set; }

    [JsonPropertyName("distanceFadeMax2_")]
    public float DistanceFadeMax2 { get; set; }

    [JsonPropertyName("createTime2_")]
    public float CreateTime2 { get; set; }

    [JsonPropertyName("createPosOffset2_")]
    public /* cVec3 */ Vector3 CreatePosOffset2 { get; set; }

    [JsonPropertyName("createAreaDistance2_")]
    public float CreateAreaDistance2 { get; set; }

    [JsonPropertyName("createAreaHeight2_")]
    public float CreateAreaHeight2 { get; set; }

    [JsonPropertyName("createAreaStartDistanceRate2_")]
    public float CreateAreaStartDistanceRate2 { get; set; }

    [JsonPropertyName("distanceSizeScaleAreaMinRate2_")]
    public float DistanceSizeScaleAreaMinRate2 { get; set; }

    [JsonPropertyName("distanceSizeScaleMin2_")]
    public float DistanceSizeScaleMin2 { get; set; }

    [JsonPropertyName("distanceSizeScaleMax2_")]
    public float DistanceSizeScaleMax2 { get; set; }

    [JsonPropertyName("distanceUvScrollScaleMin2_")]
    public float DistanceUvScrollScaleMin2 { get; set; }

    [JsonPropertyName("distanceUvScrollScaleMax2_")]
    public float DistanceUvScrollScaleMax2 { get; set; }

    [JsonPropertyName("distanceDepthFadeScaleMin2_")]
    public float DistanceDepthFadeScaleMin2 { get; set; }

    [JsonPropertyName("distanceDepthFadeScaleMax2_")]
    public float DistanceDepthFadeScaleMax2 { get; set; }

    [JsonPropertyName("windPower2_")]
    public float WindPower2 { get; set; }

    [JsonPropertyName("windPowerRate2_")]
    public float WindPowerRate2 { get; set; }

    [JsonPropertyName("windRotY2_")]
    public float WindRotY2 { get; set; }

    [JsonPropertyName("windSystemPowerOffset2_")]
    public float WindSystemPowerOffset2 { get; set; }

    [JsonPropertyName("windSystemRotYOffset2_")]
    public float WindSystemRotYOffset2 { get; set; }

    [JsonPropertyName("dirLightRate2_")]
    public float DirLightRate2 { get; set; }

    [JsonPropertyName("isUseCameraPosEmitter2_")]
    public bool IsUseCameraPosEmitter2 { get; set; }

    [JsonPropertyName("isCreateGroundPos2_")]
    public bool IsCreateGroundPos2 { get; set; }

    [JsonPropertyName("isUseWindSystem2_")]
    public bool IsUseWindSystem2 { get; set; }

    [JsonPropertyName("isUseShadowBuffer2_")]
    public bool IsUseShadowBuffer2 { get; set; }

    [JsonPropertyName("isUseDirLight2_")]
    public bool IsUseDirLight2 { get; set; }

    [JsonPropertyName("alphaInterpolateSec_")]
    public float AlphaInterpolateSec { get; set; }

    [JsonPropertyName("isXAxisBillboard_")]
    public bool IsXAxisBillboard { get; set; }

    [JsonPropertyName("alphaInterpolateSecUseArea_")]
    public bool AlphaInterpolateSecUseArea { get; set; }

    [JsonPropertyName("usePreRenderPass_")]
    public bool UsePreRenderPass { get; set; }

    [JsonPropertyName("pathMoveEnable_")]
    public bool PathMoveEnable { get; set; }

    [JsonPropertyName("pathMoveCurve_")]
    public GuiImportableCurve<float> PathMoveCurve { get; set; }

    [JsonPropertyName("pathMoveStartLocalPos_")]
    public /* cVec4 */ Vector4 PathMoveStartLocalPos { get; set; }

    [JsonPropertyName("pathMoveGoalLocalPos_")]
    public /* cVec4 */ Vector4 PathMoveGoalLocalPos { get; set; }

    [JsonPropertyName("pathMoveNormal_")]
    public /* cVec4 */ Vector4 PathMoveNormal { get; set; }

    [JsonPropertyName("pathMovePower_")]
    public float PathMovePower { get; set; }

    [JsonPropertyName("enableFrontOrientation_")]
    public bool EnableFrontOrientation { get; set; }

    [JsonPropertyName("pathMoveZRotateShakeCurve_")]
    public GuiImportableCurve<float> PathMoveZRotateShakeCurve { get; set; }

    [JsonPropertyName("pathMoveZRotateShakePower_")]
    public float PathMoveZRotateShakePower { get; set; }

    [JsonPropertyName("pathMoveZRotateShakeEndTime_")]
    public float PathMoveZRotateShakeEndTime { get; set; }

    [JsonPropertyName("pathMoveCurveFollowBiasCurve_")]
    public GuiImportableCurve<float> PathMoveCurveFollowBiasCurve { get; set; }

    [JsonPropertyName("pathMoveCurveFollowBiasLapTime_")]
    public float PathMoveCurveFollowBiasLapTime { get; set; }

}