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

public class LayoutGroupSwitch : ISceneObject
{
    [JsonPropertyName("shapeType_")]
    public uint ShapeType { get; set; }

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("useParent_")]
    public bool UseParent { get; set; }

    [JsonPropertyName("groupNames_")]
    public BindingList<BindingList<string>> GroupNames { get; set; }

    [JsonPropertyName("hashes_")]
    public BindingList<BindingList<uint>> Hashes { get; set; }

    [JsonPropertyName("insideSettings_")]
    public BindingList<bool> InsideSettings { get; set; }

    [JsonPropertyName("outsideSettings_")]
    public BindingList<bool> OutsideSettings { get; set; }

    [JsonPropertyName("useWhenHighDetailMode_")]
    public bool UseWhenHighDetailMode { get; set; }

    [JsonPropertyName("useWhenDefaultMode_")]
    public bool UseWhenDefaultMode { get; set; }
}