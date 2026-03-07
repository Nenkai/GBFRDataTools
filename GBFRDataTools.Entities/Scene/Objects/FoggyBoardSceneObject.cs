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

public class FoggyBoardSceneObject : ISceneObject
{
    [JsonPropertyName("_useParent")]
    public bool UseParent { get; set; }

    public Billboard Billboard { get; set; }
    public CB CB { get; set; }
    public CT CT { get; set; }
    public Cloudmove CloudMove { get; set; }
    public Header Header { get; set; }

    [JsonPropertyName("version2_0")]
    public Version2_0 Version2_0 { get; set; }

    [JsonPropertyName("version4_0")]
    public Version4_0 Version4_0 { get; set; }

}

public class Billboard
{
    public bool Active { get; set; }
    public float Angle { get; set; }
    public bool FollowParent { get; set; }
    public int Type { get; set; }
    public /* cVec4 */ Vector4 ViewSnapshot { get; set; }
    public bool ViewSnapshotActive { get; set; }
}

public class CB
{
    public float[] ClipRange { get; set; }
    public float ColorTextureBrightness { get; set; }
    public float ColorTextureHue { get; set; }
    public float ColorTextureSaturation { get; set; }
    public float DepthFade { get; set; }
    public float DepthFadeEffect { get; set; }
    public float DistanceFadeEffect { get; set; }
    public float[] DissolveChannel { get; set; }
    public float DissolveFixedMinimumAlpha { get; set; }
    public float DissolveSmoothIntensity { get; set; }
    public float[] DistanceFadeKeyFar { get; set; }
    public float[] DistanceFadeKeyMiddle { get; set; }
    public float[] DistanceFadeKeyNear { get; set; }
    public float FlowEffectColor { get; set; }
    public float FlowEffectMask { get; set; }
    public float FlowPower { get; set; }
    public float FlowSpeed { get; set; }
    public int IsEVCancel { get; set; }
    public float[] Mask { get; set; }
    public float[] NoiseA_UvScroll { get; set; }
    public float[] NoiseAddVec { get; set; }
    public float[] NoiseB_UvScroll { get; set; }
    public float[] NoiseChannelMask { get; set; }
    public float[] NoiseChannelUvScale { get; set; }
    public float[] NoiseG_UvScroll { get; set; }
    public float[] NoiseR_UvScroll { get; set; }
    public float NoiseUvScrollSpeedScale { get; set; }
    public float[] RGBALightMapColor { get; set; }
    public float RGBALightMapIntensity { get; set; }
    public float RGBALightMapLightBrightness { get; set; }
    public float RGBALightMapLightHue { get; set; }
    public float RGBALightMapLightMax { get; set; }
    public float RGBALightMapLightSaturation { get; set; }
    public float RGBALightMapLightScalling { get; set; }
    public float RGBALightMapShadowAdjustment { get; set; }
    public float RGBALightMapShadowBrightness { get; set; }
    public float RGBALightMapShadowHue { get; set; }
    public float RGBALightMapShadowMin { get; set; }
    public float RGBALightMapShadowSaturation { get; set; }
    public bool SurfaceDistanceFadeEffect { get; set; }
    public float[] SurfaceDistanceFadeKeyFar { get; set; }
    public float[] SurfaceDistanceFadeKeyMiddle { get; set; }
    public float[] SurfaceDistanceFadeKeyNear { get; set; }
    public float[] UvOuterAlpha { get; set; }
    public float[] UvScroll { get; set; }
    public int UvScrollEffectColor { get; set; }
    public int UvScrollEffectFlow { get; set; }
    public int UvScrollEffectMask { get; set; }
}

public class CT
{
    public Color Color { get; set; }
    public Color Dissolve { get; set; }
    public Color Flow { get; set; }
    public Color Mask { get; set; }
    public Color Noise { get; set; }
    public Color NoiseMask { get; set; }
    public Color RGBALightMap { get; set; }
}

public class Color
{
    public bool Active { get; set; }
    public float[] Base { get; set; }
    public string Filepath { get; set; }
}

public class Cloudmove
{
    public bool Active { get; set; }
    public bool ActiveEndFade { get; set; }
    public bool ActiveEndFadeEarlier { get; set; }
    public bool ActiveStartFade { get; set; }
    public bool ActiveStartFadeCorrect { get; set; }
    public bool ActiveStartFadeDelay { get; set; }
    public bool DissolveWithAlphaFade { get; set; }
    public float EndFadeEarlierRate { get; set; }
    public float EndFadePosition { get; set; }
    public float[] EndPosition { get; set; }
    public bool IsLoop { get; set; }
    public float Offset { get; set; }
    public float RestartTime { get; set; }
    public float Speed { get; set; }
    public float StartFadeDelayRate { get; set; }
    public float StartFadePosition { get; set; }
    public float[] StartPosition { get; set; }
    public float WaitTime { get; set; }
}

public class Header
{
    public int version { get; set; }
}

public class Version2_0
{
    public float Intensity { get; set; }
    public bool IntensityAutomation { get; set; }
    public float InterpolateSec { get; set; }
    public bool InterpolateSecUseArea { get; set; }
    public bool IsEVCancel { get; set; }
    public bool UseParent { get; set; }
}

public class Version4_0
{
    public float ScaleBias { get; set; }
    public float[] ShadowColor { get; set; }
    public bool UseBackfaceCulling { get; set; }
    public bool UseColorAndMaskClampState { get; set; }
    public bool UsePreRenderPass { get; set; }
    public bool UseShadow { get; set; }
}
