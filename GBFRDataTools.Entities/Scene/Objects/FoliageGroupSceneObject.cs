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

public class FoliageGroupSceneObject : ISceneObject
{
    public GrassRenderParamsVector GrassRenderParamsVector { get; set; }
    public GrassShaderParams GrassShaderParams { get; set; }

    [JsonPropertyName("mNoiseTexPath")]
    public string NoiseTexPath { get; set; }

    [JsonPropertyName("mNormalMode")]
    public int NormalMode { get; set; }

    [JsonPropertyName("mNotDeferred")]
    public bool NotDeferred { get; set; }

    [JsonPropertyName("mWindTexPath")]
    public string WindTexPath { get; set; }

    [JsonPropertyName("mEyeMoveCameraLen")]
    public float EyeMoveCameraLen { get; set; }
}

public class GrassRenderParamsVector
{
    public int Size { get; set; }

    /// <summary>
    /// Base64 encoded
    /// </summary>
    public byte[] Binary { get; set; }

    public object[] Vector { get; set; }
    public int Version { get; set; }
}


public class GrassShaderParams
{
    public float[] BaseColor { get; set; }
    public float[] ColorA { get; set; }
    public float[] ColorB { get; set; }
    public bool EnableDitheredNearCameraFade { get; set; }
    public bool EnableScaledNearCameraFade { get; set; }
    public float EyeMoveCameraLength { get; set; }
    public float EyeMovePower { get; set; }
    public float[] FarBrightness { get; set; }
    public float IdlingSpeed { get; set; }
    public float IdlingSpeed2 { get; set; }
    public float IdlingStrength { get; set; }
    public float IdlingStrength2 { get; set; }
    public float[] RootColor { get; set; }
    public bool UseEyeMove { get; set; }
    public bool UseOtherCalculation { get; set; }
    public float[] WaveColor { get; set; }
    public float WaveInterval { get; set; }
    public float WaveScale_1 { get; set; }
    public float WaveScale_2 { get; set; }
    public float WaveSpeed { get; set; }
    public float WaveStrength { get; set; }
    public float WaveTilingSpeed_1 { get; set; }
    public float WaveTilingSpeed_2 { get; set; }
    public float WindAngleDegree { get; set; }
    public float WindAngleOffset { get; set; }
}
