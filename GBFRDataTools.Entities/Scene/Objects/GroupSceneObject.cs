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

public class GroupSceneObject : ISceneObject
{
    [JsonPropertyName("timelineMoveStart_")]
    public /* cMtx44 */ Matrix4x4 TimelineMoveStart { get; set; }

    [JsonPropertyName("timelineMoveEnd_")]
    public /* cMtx44 */ Matrix4x4 TimelineMoveEnd { get; set; }
}