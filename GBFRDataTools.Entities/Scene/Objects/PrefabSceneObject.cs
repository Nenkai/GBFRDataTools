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

public class PrefabSceneObject : ISceneObject
{
    [JsonPropertyName("mFilePath")]
    public string FilePath { get; set; }

    [JsonPropertyName("mReferenceHierarchy")]
    public int ReferenceHierarchy { get; set; }

    [JsonPropertyName("mPrefabController")]
    public int PrefabController { get; set; }
}