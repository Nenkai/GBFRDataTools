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

public class WindSceneObject : ISceneObject
{
    [JsonPropertyName("windParamData_")]
    public WindParamData WindParamData { get; set; }
}

public class WindParamData /* WindSceneObject::WindParamData */
{
    [JsonPropertyName("windType_")]
    public uint WindType { get; set; }

    [JsonPropertyName("grassWindPrior_")]
    public uint GrassWindPrior { get; set; }

    [JsonPropertyName("windVelocity_")]
    public float WindVelocity { get; set; }

    [JsonPropertyName("windPower_")]
    public float WindPower { get; set; }

    [JsonPropertyName("isDummyWind_")]
    public bool IsDummyWind { get; set; }

    [JsonPropertyName("isStageWind_")]
    public bool IsStageWind { get; set; }

    [JsonPropertyName("OBBHalf_")]
    public cVec3 OBBHalf { get; set; }

    [JsonPropertyName("coneHeight_")]
    public float ConeHeight { get; set; }

    [JsonPropertyName("coneRadius_")]
    public float ConeRadius { get; set; }

    [JsonPropertyName("sphereRadius_")]
    public float SphereRadius { get; set; }

    [JsonPropertyName("endCylinderPos_")]
    public cVec3 EndCylinderPos { get; set; }

    [JsonPropertyName("cylinderRadius_")]
    public float CylinderRadius { get; set; }

    [JsonPropertyName("windSpeedOscillationFirst_")]
    public float WindSpeedOscillationFirst { get; set; }

    [JsonPropertyName("windSpeedOscillationSecond_")]
    public float WindSpeedOscillationSecond { get; set; }

    [JsonPropertyName("windWavePlayTimeFirst_")]
    public float WindWavePlayTimeFirst { get; set; }

    [JsonPropertyName("windWavePlayTimeSecond_")]
    public float WindWavePlayTimeSecond { get; set; }

    [JsonPropertyName("windSpeedCurveFirst_")]
    public GuiImportableCurve<float> WindSpeedCurveFirst { get; set; }

    [JsonPropertyName("windSpeedCurveSecond_")]
    public GuiImportableCurve<float> WindSpeedCurveSecond { get; set; }

    [JsonPropertyName("windSpeedCurveFirstPlayer_")]
    public /* cy::CurvePlayer */ float[] WindSpeedCurveFirstPlayer { get; set; }

    [JsonPropertyName("windSpeedCurveSecondPlayer_")]
    public /* cy::CurvePlayer */ float[] WindSpeedCurveSecondPlayer { get; set; }

    [JsonPropertyName("isWindSpeedCurveFirst_")]
    public bool IsWindSpeedCurveFirst { get; set; }

    [JsonPropertyName("isWindSpeedCurveSecond_")]
    public bool IsWindSpeedCurveSecond { get; set; }

    [JsonPropertyName("windDirOscillationFirst_")]
    public cVec2 WindDirOscillationFirst { get; set; }

    [JsonPropertyName("windDirOscillationSecond_")]
    public cVec2 WindDirOscillationSecond { get; set; }

    [JsonPropertyName("windDirWavePlayTimeFirst_")]
    public float WindDirWavePlayTimeFirst { get; set; }

    [JsonPropertyName("windDirWavePlayTimeSecond_")]
    public float WindDirWavePlayTimeSecond { get; set; }

    [JsonPropertyName("reverseFlag_")]
    public bool ReverseFlag { get; set; }

    [JsonPropertyName("shakeSpeedRate_")]
    public float ShakeSpeedRate { get; set; }

    [JsonPropertyName("borderImpactRate_")]
    public float BorderImpactRate { get; set; }

    [JsonPropertyName("spFlgShortHairRangeUp_")]
    public bool SpFlgShortHairRangeUp { get; set; }

    [JsonPropertyName("windVecQuat_")]
    public cVec4 WindVecQuat { get; set; }

    [JsonPropertyName("windVecDeg_")]
    public cVec3 WindVecDeg { get; set; }

    [JsonPropertyName("windInterpolateSec_")]
    public float WindInterpolateSec { get; set; }

    [JsonPropertyName("windInterpolateSecUseArea_")]
    public bool WindInterpolateSecUseArea { get; set; }
}