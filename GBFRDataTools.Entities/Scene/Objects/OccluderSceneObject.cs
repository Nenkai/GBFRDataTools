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

public class OccluderSceneObject : ISceneObject
{
    [JsonPropertyName("bDispWFOnly_")]
    public bool BDispWFOnly { get; set; }

    [JsonPropertyName("selectIndexOfShapeTypes_")]
    public int SelectIndexOfShapeTypes { get; set; }

    [JsonPropertyName("bBackFaceCulling_front_")]
    public bool BackFaceCulling_front { get; set; }

    [JsonPropertyName("bBackFaceCulling_back_")]
    public bool BackFaceCulling_back { get; set; }

    [JsonPropertyName("bBackFaceCulling_right_")]
    public bool BackFaceCulling_right { get; set; }

    [JsonPropertyName("bBackFaceCulling_left_")]
    public bool BackFaceCulling_left { get; set; }

    [JsonPropertyName("bSwichable_")]
    public bool Swichable { get; set; }

    [JsonPropertyName("bDefaultInActive_")]
    public bool DefaultInActive { get; set; }

    [JsonPropertyName("bPhotoModeActive_")]
    public bool PhotoModeActive { get; set; }

    [JsonPropertyName("switchableId_")]
    public int SwitchableId { get; set; }
}