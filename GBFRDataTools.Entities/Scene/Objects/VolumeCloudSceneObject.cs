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
using GBFRDataTools.Entities.Converters;
using GBFRDataTools.Entities.Preset;

using MessagePack;

namespace GBFRDataTools.Entities.Scene.Objects;

public class VolumeCloudSceneObject : ISceneObject
{
    [JsonPropertyName("parameter_")]
    public VolumeCloudSceneObjectParameter Parameter { get; set; }
}

public class VolumeCloudSceneObjectParameter
{
    [JsonPropertyName("lightRotation_")]
    public /* cVec2 */ Vector2 LightRotation { get; set; }

    [JsonPropertyName("scrollDir_")]
    public /* cVec3 */ Vector3 ScrollDir { get; set; }

    [JsonPropertyName("scrollVelocity_")]
    public float ScrollVelocity { get; set; }

    [JsonPropertyName("scrollVelocity2_")]
    public float ScrollVelocity2 { get; set; }

    [JsonPropertyName("angularVelocity_")]
    public float AngularVelocity { get; set; }

    [JsonPropertyName("rotateAxis_")]
    public /* cVec3 */ Vector3 RotateAxis { get; set; }

    [JsonPropertyName("areaFadeSmoothness_")]
    public float AreaFadeSmoothness { get; set; }

    [JsonPropertyName("frontFadeDistance_")]
    public float FrontFadeDistance { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; }

    [JsonPropertyName("density_")]
    public float Density { get; set; }

    [JsonPropertyName("fineDetail_")]
    public float FineDetail { get; set; }

    [JsonPropertyName("densityDeviation_")]
    public float DensityDeviation { get; set; }

    [JsonPropertyName("shadowAlpha_")]
    public float ShadowAlpha { get; set; }

    [JsonPropertyName("flatScale_")]
    public float FlatScale { get; set; }

    [JsonPropertyName("distortionScaleNear_")]
    public float DistortionScaleNear { get; set; }

    [JsonPropertyName("distortionScaleFar_")]
    public float DistortionScaleFar { get; set; }

    [JsonPropertyName("distortionFrequency_")]
    public float DistortionFrequency { get; set; }

    [JsonPropertyName("isRenderCloud_")]
    public bool IsRenderCloud { get; set; }

    [JsonPropertyName("isRenderShadow_")]
    public bool IsRenderShadow { get; set; }

    [JsonPropertyName("useSelfShadowing_")]
    public bool UseSelfShadowing { get; set; }

    [JsonPropertyName("useLighting_")]
    public bool UseLighting { get; set; }

    [JsonPropertyName("useShadowing_")]
    public bool UseShadowing { get; set; }

    [JsonPropertyName("depthFadeScale_")]
    public float DepthFadeScale { get; set; }

    [JsonPropertyName("depthFadeCategory_")]
    public uint DepthFadeCategory { get; set; }

    [JsonPropertyName("depthFadeScale2_")]
    public float DepthFadeScale2 { get; set; }

    [JsonPropertyName("depthFadeCategoryDebug_")]
    public bool DepthFadeCategoryDebug { get; set; }

    [JsonPropertyName("useTurbulence_")]
    public bool UseTurbulence { get; set; }

    [JsonPropertyName("useTurbulenceDebug_")]
    public bool UseTurbulenceDebug { get; set; }

    [JsonPropertyName("turbulenceDistanceScale_")]
    public float TurbulenceDistanceScale { get; set; }

    [JsonPropertyName("turbulencePower_")]
    public float TurbulencePower { get; set; }

    [JsonPropertyName("turbulencePeriod_")]
    public float TurbulencePeriod { get; set; }

    [JsonPropertyName("turbulenceStrength_")]
    public float TurbulenceStrength { get; set; }

    [JsonPropertyName("usePlaneCloud_")]
    public bool UsePlaneCloud { get; set; }

    [JsonPropertyName("planeCloudGroundY_")]
    public float PlaneCloudGroundY { get; set; }

    [JsonPropertyName("planeCloudGroundFadeScale_")]
    public float PlaneCloudGroundFadeScale { get; set; }

    [JsonPropertyName("planeCloudWallHeightScale_")]
    public float PlaneCloudWallHeightScale { get; set; }

    [JsonPropertyName("planeCloudWallStrength_")]
    public float PlaneCloudWallStrength { get; set; }

    [JsonPropertyName("baseColor_")]
    public GuiColor BaseColor { get; set; }

    [JsonPropertyName("sunnyColor_")]
    public GuiColor SunnyColor { get; set; }

    [JsonPropertyName("sunnyColorPower_")]
    public float SunnyColorPower { get; set; }

    [JsonPropertyName("shadeColor_")]
    public GuiColor ShadeColor { get; set; }

    [JsonPropertyName("shadeColorPower_")]
    public float ShadeColorPower { get; set; }

    [JsonPropertyName("shadowColor_")]
    public GuiColor ShadowColor { get; set; }

    [JsonPropertyName("fogColorA_")]
    public GuiColor FogColorA { get; set; }

    [JsonPropertyName("fogColorB_")]
    public GuiColor FogColorB { get; set; }

    [JsonPropertyName("fogType_")]
    public uint FogType { get; set; }

    [JsonPropertyName("fogDistanceScale_")]
    public float FogDistanceScale { get; set; }

    [JsonPropertyName("fogPower_")]
    public float FogPower { get; set; }

    [JsonPropertyName("fogColorPowerPlus_")]
    public float FogColorPowerPlus { get; set; }

    [JsonPropertyName("fogColorPowerMinus_")]
    public float FogColorPowerMinus { get; set; }

    [JsonPropertyName("fogInvert_")]
    public bool FogInvert { get; set; }

    [JsonPropertyName("colorSpotSunny_")]
    public GuiColor ColorSpotSunny { get; set; }

    [JsonPropertyName("colorSpotShade_")]
    public GuiColor ColorSpotShade { get; set; }

    [JsonPropertyName("colorBlendRatio_")]
    public float ColorBlendRatio { get; set; }

    [JsonPropertyName("baseColor2_")]
    public GuiColor BaseColor2 { get; set; }

    [JsonPropertyName("sunnyColor2_")]
    public GuiColor SunnyColor2 { get; set; }

    [JsonPropertyName("shadeColor2_")]
    public GuiColor ShadeColor2 { get; set; }

    [JsonPropertyName("shadowColor2_")]
    public GuiColor ShadowColor2 { get; set; }

    [JsonPropertyName("fogColorA2_")]
    public GuiColor FogColorA2 { get; set; }

    [JsonPropertyName("fogColorB2_")]
    public GuiColor FogColorB2 { get; set; }

    [JsonPropertyName("fogColorPowerPlus2_")]
    public float FogColorPowerPlus2 { get; set; }

    [JsonPropertyName("fogColorPowerMinus2_")]
    public float FogColorPowerMinus2 { get; set; }

    [JsonPropertyName("colorSpotSunny2_")]
    public GuiColor ColorSpotSunny2 { get; set; }

    [JsonPropertyName("colorSpotShade2_")]
    public GuiColor ColorSpotShade2 { get; set; }

    [JsonPropertyName("colorSpotRatio_")]
    public /* cVec3 */ Vector3 ColorSpotRatio { get; set; }

    [JsonPropertyName("colorSpotPower_")]
    public float ColorSpotPower { get; set; }

    [JsonPropertyName("isColorSpotDebug_")]
    public bool IsColorSpotDebug { get; set; }

    [JsonPropertyName("shadowHSV_")]
    public /* cVec3 */ Vector3 ShadowHSV { get; set; }

    [JsonPropertyName("enableMask_")]
    public bool EnableMask { get; set; }

    [JsonPropertyName("texturePLUTPath_")]
    public string TexturePLUTPath { get; set; }

    [JsonPropertyName("textureMaskPath_")]
    public string TextureMaskPath { get; set; }

    [JsonPropertyName("textureHeightMaskPath_")]
    public string TextureHeightMaskPath { get; set; }
}