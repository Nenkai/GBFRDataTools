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

public class AreaSceneObject : ISceneObject
{
    [JsonPropertyName("_areaColor")]
    public GuiColor AreaColor { get; set; }

    [JsonPropertyName("_areaRadius")]
    public float AreaRadius { get; set; }

    [JsonPropertyName("_areaType")]
    public uint AreaType { get; set; }

    [JsonPropertyName("_priority")]
    public int Priority { get; set; }

    [JsonPropertyName("_interpolateSec")]
    public float InterpolateSec { get; set; }

    [JsonPropertyName("_useParent")]
    public bool UseParent { get; set; }

    // TODO: Inline array
    [JsonPropertyName("_hierarchy")]
    public /* cy::AreaSceneObject::Data */ object[] Hierarchy { get; set; }

    [JsonPropertyName("_composite")]
    public /* cy::AreaSceneObject::Data */ object[] Composite { get; set; }

    [JsonPropertyName("_curve")]
    public /* cy::AreaSceneObject::Data */ object[] Curve { get; set; }
}