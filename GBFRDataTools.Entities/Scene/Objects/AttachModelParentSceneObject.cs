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

public class AttachModelParentSceneObject : ISceneObject
{
    [JsonPropertyName("presetIndex_")]
    public int PresetIndex { get; set; }

    [JsonPropertyName("selectID_")]
    public int SelectID { get; set; }

    [JsonPropertyName("targetCategory_")]
    public uint TargetCategory { get; set; }

    [JsonPropertyName("targetID_")]
    public uint TargetID { get; set; }
}