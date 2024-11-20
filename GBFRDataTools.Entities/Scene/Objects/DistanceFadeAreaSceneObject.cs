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

public class DistanceFadeAreaSceneObject : ISceneObject
{
    [JsonPropertyName("areaColor_")]
    public GuiColor AreaColor { get; set; }

    [JsonPropertyName("areaRadius_")]
    public float AreaRadius { get; set; }

    [JsonPropertyName("centerAreaRatio_")]
    public float CenterAreaRatio { get; set; }

    [JsonPropertyName("areaType_")]
    public uint AreaType { get; set; }

    [JsonPropertyName("priority_")]
    public int Priority { get; set; }

    [JsonPropertyName("areaA_UUID_")]
    public /* cy::ISceneObject::UUID */ UUID AreaA_UUID { get; set; }

    [JsonPropertyName("areaB_UUID_")]
    public /* cy::ISceneObject::UUID */ UUID AreaB_UUID { get; set; }

    [JsonPropertyName("interpolateCurve_")]
    public GuiImportableCurve<float> InterpolateCurve { get; set; }
}