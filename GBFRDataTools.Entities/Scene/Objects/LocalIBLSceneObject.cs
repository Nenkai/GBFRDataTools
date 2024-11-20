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

public class LocalIBLSceneObject : ISceneObject
{
    [JsonPropertyName("_blendRate")]
    public float BlendRate { get; set; }

    [JsonPropertyName("_diffuseRate")]
    public GuiColor DiffuseRate { get; set; }

    [JsonPropertyName("intensity_")]
    public float Intensity { get; set; }

    [JsonPropertyName("_specularRate")]
    public GuiColor SspecularRate { get; set; }

    [JsonPropertyName("specularIntensity_")]
    public float SpecularIntensity { get; set; }

    [JsonPropertyName("specularRoughnessOffset_")]
    public float SpecularRoughnessOffset { get; set; }

    [JsonPropertyName("useTexGlobalIBL_")]
    public bool UseTexGlobalIBL { get; set; }

    [JsonPropertyName("intencityInterpolateSec_")]
    public float IntencityInterpolateSec { get; set; }

    [JsonPropertyName("intencityInterpolateSecUseArea_")]
    public bool IntencityInterpolateSecUseArea { get; set; }

    [JsonPropertyName("influenceDistanceFadeCorrectly_")]
    public bool InfluenceDistanceFadeCorrectly { get; set; }
}