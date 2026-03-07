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

public class PlacementInfo : ISceneObject
{
    [JsonPropertyName("category_")]
    public int Category { get; set; }

    [JsonPropertyName("groupType_")]
    public int GroupType { get; set; }

    [JsonPropertyName("materials_")]
    public BindingList<object> Materials { get; set; } = [];

    [JsonPropertyName("memberType_")]
    public int MemberType { get; set; }

    [JsonPropertyName("values_")]
    public BindingList<ulong> Values { get; set; } = [];

    [JsonPropertyName("points_")]
    public BindingList<Matrix4x4> Points { get; set; } = [];

    [JsonPropertyName("cameraFadeSettings_")]
    public object[] CameraFadeSettings { get; set; }

    [JsonPropertyName("finishBehaviorFunctionArgs_")]
    public /* cy::BehaviorFunctionArguments */ BehaviorFunctionArguments FinishBehaviorFunctionArgs { get; set; }

    [JsonPropertyName("checkFinishBehaviorFunctionArgs_")]
    public /* cy::BehaviorFunctionArguments */ BehaviorFunctionArguments CheckFinishBehaviorFunctionArgs { get; set; }

    [JsonPropertyName("text_")]
    public string Text { get; set; }
}
