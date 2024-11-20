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

public class AmbientAreaLightSceneObject : ISceneObject
{
    [JsonPropertyName("_bakeAllLock")]
    public bool BakeAllLock { get; set; }

    [JsonPropertyName("_blendRate")]
    public float BlendRate { get; set; }

    [JsonPropertyName("_bgBlendRate")]
    public float BgBlendRate { get; set; }

    [JsonPropertyName("_characterBlendRate")]
    public float CharacterBlendRate { get; set; }

    [JsonPropertyName("specularPower_")]
    public float SpecularPower { get; set; }

    [JsonPropertyName("fadePower_")]
    public float FadePower { get; set; }

    [JsonPropertyName("isBoxShape_")]
    public bool IsBoxShape { get; set; }

    [JsonPropertyName("_categoryTypeFlag")]
    public uint CategoryTypeFlag { get; set; }

    [JsonPropertyName("_colorX")]
    public GuiColor ColorX { get; set; }

    [JsonPropertyName("_intensityX")]
    public float IntensityX { get; set; }

    [JsonPropertyName("_colorY")]
    public GuiColor ColorY { get; set; }

    [JsonPropertyName("_intensityY")]
    public float IntensityY { get; set; }

    [JsonPropertyName("_colorZ")]
    public GuiColor ColorZ { get; set; }

    [JsonPropertyName("_intensityZ")]
    public float IntensityZ { get; set; }

    [JsonPropertyName("_colorMinusX")]
    public GuiColor ColorMinusX { get; set; }

    [JsonPropertyName("_intensityMinusX")]
    public float IntensityMinusX { get; set; }

    [JsonPropertyName("_colorMinusY")]
    public GuiColor ColorMinusY { get; set; }

    [JsonPropertyName("_intensityMinusY")]
    public float IntensityMinusY { get; set; }

    [JsonPropertyName("_colorMinusZ")]
    public GuiColor ColorMinusZ { get; set; }

    [JsonPropertyName("_intensityMinusZ")]
    public float IntensityMinusZ { get; set; }

    [JsonPropertyName("_cubeRotFollowJoint")]
    public bool CubeRotFollowJoint { get; set; }

    [JsonPropertyName("_cubeRot")]
    public cVec3 CubeRot { get; set; }

    [JsonPropertyName("intencityInterpolateSec_")]
    public float IntencityInterpolateSec { get; set; }

    [JsonPropertyName("intencityInterpolateSecUseArea_")]
    public bool IntencityInterpolateSecUseArea { get; set; }

    [JsonPropertyName("isSubtract_")]
    public bool IsSubtract { get; set; }

    [JsonPropertyName("isDistanceCulling_")]
    public bool IsDistanceCulling { get; set; }

    [JsonPropertyName("ignoreShadow_")]
    public bool IgnoreShadow { get; set; }
}