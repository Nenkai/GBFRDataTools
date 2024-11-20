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

public class DeferredDecalObject : ISceneObject
{
    [JsonPropertyName("SaveData")]
    public DecalSaveData SaveData { get; set; }

    [JsonPropertyName("alphaInterpolateSec_")]
    public float AlphaInterpolateSec { get; set; }

    [JsonPropertyName("alphaInterpolateSecUseArea_")]
    public bool AlphaInterpolateSecUseArea { get; set; }

    [JsonPropertyName("bias_")]
    public float Bias { get; set; }
}

public class DecalSaveData /* DeferredDecalObject::DecalSaveData */
{
    [JsonPropertyName("Priority")]
    public int Priority { get; set; }

    [JsonPropertyName("shaderType")]
    public byte ShaderType { get; set; }

    [JsonPropertyName("AlbedoPath")]
    public string AlbedoPath { get; set; }

    [JsonPropertyName("NormalPath")]
    public string NormalPath { get; set; }

    [JsonPropertyName("MROPath")]
    public string MROPath { get; set; }

    [JsonPropertyName("MaskPath")]
    public string MaskPath { get; set; }

    [JsonPropertyName("useAlbedo")]
    public bool UseAlbedo { get; set; }

    [JsonPropertyName("useNormal")]
    public bool UseNormal { get; set; }

    [JsonPropertyName("useMRO")]
    public bool UseMRO { get; set; }

    [JsonPropertyName("useRoughness")]
    public bool UseRoughness { get; set; }

    [JsonPropertyName("useMetallic")]
    public bool UseMetallic { get; set; }

    [JsonPropertyName("useOcclusion")]
    public bool UseOcclusion { get; set; }

    [JsonPropertyName("alpha")]
    public float Alpha { get; set; }

    [JsonPropertyName("cliffAlpha")]
    public float CliffAlpha { get; set; }

    [JsonPropertyName("AffectAngleAlpha")]
    public bool AffectAngleAlpha { get; set; }

    [JsonPropertyName("useMask_Albedo_A")]
    public bool UseMask_Albedo_A { get; set; }

    [JsonPropertyName("uselengthFade")]
    public bool UselengthFade { get; set; }

    [JsonPropertyName("lengthFadeReverse")]
    public bool LengthFadeReverse { get; set; }

    [JsonPropertyName("lengthFadeAlphaDistance")]
    public float LengthFadeAlphaDistance { get; set; }

    [JsonPropertyName("lengthFadeMin")]
    public float LengthFadeMin { get; set; }

    [JsonPropertyName("lengthFadeMax")]
    public float LengthFadeMax { get; set; }

    [JsonPropertyName("lengthFadePower")]
    public float LengthFadePower { get; set; }

    [JsonPropertyName("hue")]
    public float Hue { get; set; }

    [JsonPropertyName("saturation")]
    public float Saturation { get; set; }

    [JsonPropertyName("brightness")]
    public float Brightness { get; set; }

    [JsonPropertyName("contrast")]
    public float Contrast { get; set; }

    [JsonPropertyName("UvScrollSpeed")]
    public cVec2 UvScrollSpeed { get; set; }

    [JsonPropertyName("UvTiling")]
    public cVec2 UvTiling { get; set; }

    [JsonPropertyName("UvClipX")]
    public cVec2 UvClipX { get; set; }

    [JsonPropertyName("UvClipY")]
    public cVec2 UvClipY { get; set; }

    [JsonPropertyName("UvFluffy")]
    public float UvFluffy { get; set; }

    [JsonPropertyName("useMaskTexture")]
    public bool UseMaskTexture { get; set; }

    [JsonPropertyName("useMask_R")]
    public bool UseMask_R { get; set; }

    [JsonPropertyName("useMask_G")]
    public bool UseMask_G { get; set; }

    [JsonPropertyName("useMask_B")]
    public bool UseMask_B { get; set; }

    [JsonPropertyName("useMask_A")]
    public bool UseMask_A { get; set; }

    [JsonPropertyName("useMask_Box")]
    public bool UseMask_Box { get; set; }

    [JsonPropertyName("useMask_Sphere")]
    public bool UseMask_Sphere { get; set; }

    [JsonPropertyName("UvMaskTiling")]
    public cVec2 UvMaskTiling { get; set; }

    [JsonPropertyName("useOverrideRoughness")]
    public bool UseOverrideRoughness { get; set; }

    [JsonPropertyName("OverrideRoughness")]
    public float OverrideRoughness { get; set; }

    [JsonPropertyName("useWet")]
    public bool UseWet { get; set; }

    [JsonPropertyName("albedoIntensity")]
    public float AlbedoIntensity { get; set; }

    [JsonPropertyName("CutOcclusion")]
    public bool CutOcclusion { get; set; }

    [JsonPropertyName("parallaxStepScale")]
    public float ParallaxStepScale { get; set; }

    [JsonPropertyName("stepCount")]
    public float StepCount { get; set; }

    [JsonPropertyName("bakeShadow")]
    public bool BakeShadow { get; set; }

    [JsonPropertyName("useDirectivityCamera")]
    public bool UseDirectivityCamera { get; set; }

    [JsonPropertyName("directivityCameraAngle")]
    public float DirectivityCameraAngle { get; set; }

    [JsonPropertyName("directivityCameraRadius")]
    public float DirectivityCameraRadius { get; set; }

    [JsonPropertyName("directivityCameraRate")]
    public float DirectivityCameraRate { get; set; }

    [JsonPropertyName("useDirectivityReverse")]
    public bool UseDirectivityReverse { get; set; }

    [JsonPropertyName("useDirectivityAlphaReverse")]
    public bool UseDirectivityAlphaReverse { get; set; }
}
