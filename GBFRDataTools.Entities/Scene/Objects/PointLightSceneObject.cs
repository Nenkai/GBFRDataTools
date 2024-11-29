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

public class PointLightSceneObject : ISceneObject
{
    [JsonPropertyName("data_")]
    public PointLightData Data { get; set; }

    [JsonPropertyName("opacityInterpolateSec_")]
    public float OpacityInterpolateSec { get; set; }

    [JsonPropertyName("opacityInterpolateSecUseArea_")]
    public bool OpacityInterpolateSecUseArea { get; set; }

    [JsonPropertyName("useDeselect_")]
    public bool UseDeselect { get; set; }

    [JsonPropertyName("deselectPos_")]
    public /* cVec4 */ Vector4 DeselectPos { get; set; }

    [JsonPropertyName("attenuationRate_")]
    public float AttenuationRate { get; set; }

    [JsonPropertyName("useEventCharaLight_")]
    public bool UseEventCharaLight { get; set; }

    [JsonPropertyName("targetList_")]
    public object[] TargetList { get; set; } // MaterialsHashInfo

    [JsonPropertyName("useMaskTex_")]
    public bool UseMaskTex { get; set; }

    [JsonPropertyName("maskTexFilePath_")]
    public string MaskTexFilePath { get; set; }
}

public class PointLightData
{
    [JsonPropertyName("bAnimation_")]
    public int BAnimation { get; set; }

    [JsonPropertyName("bDistanceInterpolate_")]
    public int BDistanceInterpolate { get; set; }

    [JsonPropertyName("curvePlayer_")]
    public /*cy::CurvePlayer*/ float[] CurvePlayer { get; set; }

    [JsonPropertyName("color_")]
    public GuiColor Color { get; set; }

    [JsonPropertyName("diffuseIntensity_")]
    public float DiffuseIntensity { get; set; }

    [JsonPropertyName("specularIntensity_")]
    public float SpecularIntensity { get; set; }

    [JsonPropertyName("maskScale_")]
    public float MaskScale { get; set; }

    [JsonPropertyName("outerRadius_")]
    public float OuterRadius { get; set; }

    [JsonPropertyName("innerRadius_")]
    public float InnerRadius { get; set; }

    [JsonPropertyName("atteAdjust_")]
    public float AtteAdjust { get; set; }

    [JsonPropertyName("atteClipSpaceRadius_")]
    public float AtteClipSpaceRadius { get; set; }

    [JsonPropertyName("atteClipSpaceSmallRadius_")]
    public float AtteClipSpaceSmallRadius { get; set; }

    [JsonPropertyName("bAtteClipSpaceSmooth_")]
    public int BAtteClipSpaceSmooth { get; set; }

    [JsonPropertyName("bAtteModelTire_")]
    public int BAtteModelTire { get; set; }

    [JsonPropertyName("bAtteModelBlind_")]
    public int BAtteModelBlind { get; set; }

    [JsonPropertyName("effectiveDist_")]
    public float EffectiveDist { get; set; }

    [JsonPropertyName("luminousPower_")]
    public float LuminousPower { get; set; }

    [JsonPropertyName("luminousPowerCurve_")]
    public GuiImportableCurve<float> LuminousPowerCurve { get; set; }

    [JsonPropertyName("quadWidth_")]
    public float QuadWidth { get; set; }

    [JsonPropertyName("quadHeight_")]
    public float QuadHeight { get; set; }

    [JsonPropertyName("capsuleRadius_")]
    public float CapsuleRadius { get; set; }

    [JsonPropertyName("capsuleLength_")]
    public float CapsuleLength { get; set; }

    [JsonPropertyName("isUsingPerspective_")]
    public int IsUsingPerspective { get; set; }

    [JsonPropertyName("dynamicShadowClipDepthOffset_")]
    public float DynamicShadowClipDepthOffset { get; set; }

    [JsonPropertyName("dynamicShadowBias_")]
    public float DynamicShadowBias { get; set; }

    [JsonPropertyName("bNPRNegativeShadow_")]
    public int BNPRNegativeShadow { get; set; }

    [JsonPropertyName("softShadowScale_")]
    public float SoftShadowScale { get; set; }

    [JsonPropertyName("fSpotOuterAngle_")]
    public float FSpotOuterAngle { get; set; }

    [JsonPropertyName("fSpotInnerAngle_")]
    public float FSpotInnerAngle { get; set; }

    [JsonPropertyName("bCastDynamicShadow_")]
    public int BCastDynamicShadow { get; set; }

    [JsonPropertyName("castDynamicShadowFrequency_")]
    public uint CastDynamicShadowFrequency { get; set; }

    [JsonPropertyName("iESIndex_")]
    public byte IESIndex { get; set; }

    [JsonPropertyName("categoryTypeFlag_")]
    public uint CategoryTypeFlag { get; set; }

    [JsonPropertyName("bConstrainCamera_")]
    public int BConstrainCamera { get; set; }

    [JsonPropertyName("shadowCastModelType_")]
    public byte ShadowCastModelType { get; set; }

    [JsonPropertyName("areaLightType_")]
    public uint AreaLightType { get; set; }

    [JsonPropertyName("distanceCurve_")]
    public GuiImportableCurve<float> DistanceCurve { get; set; }

    [JsonPropertyName("luminousPowerMin_")]
    public float LuminousPowerMin { get; set; }

    [JsonPropertyName("luminousPowerB_")]
    public float LuminousPowerB { get; set; }

    [JsonPropertyName("luminousPowerBMin_")]
    public float LuminousPowerBMin { get; set; }

    [JsonPropertyName("colorB_")]
    public GuiColor ColorB { get; set; }

    [JsonPropertyName("distanceA_")]
    public float DistanceA { get; set; }

    [JsonPropertyName("distanceB_")]
    public float DistanceB { get; set; }

    [JsonPropertyName("curvePlayerTime_")]
    public float CurvePlayerTime { get; set; }

    [JsonPropertyName("curvePlayerTimeB_")]
    public float CurvePlayerTimeB { get; set; }

    [JsonPropertyName("curveTimeOfset_")]
    public float CurveTimeOfset { get; set; }

    [JsonPropertyName("serializeVersion_")]
    public uint SerializeVersion { get; set; }

    [JsonPropertyName("ignoreShadow_")]
    public bool IgnoreShadow { get; set; }

}