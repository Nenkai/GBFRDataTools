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

public class EffectColorChangeSceneObject : ISceneObject
{
    [JsonPropertyName("_maniRadius")]
    public /* ManipulatableFloat */ float ManiRadius { get; set; }

    [JsonPropertyName("_shapeType")]
    public uint ShapeType { get; set; }

    [JsonPropertyName("_shapeColor")]
    public GuiColor ShapeColor { get; set; }

    [JsonPropertyName("colorRate_")]
    public GuiColor ColorRate { get; set; }

    [JsonPropertyName("intensity_")]
    public float Intensity { get; set; }
}