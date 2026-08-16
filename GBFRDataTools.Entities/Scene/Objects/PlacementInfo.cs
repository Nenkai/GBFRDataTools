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
    public MemberType MemberType { get; set; }

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

public enum MemberType
{
    Member = 0,
    Enemy = 1,
    Effect = 2,
    Zone = 3,
    Behavior = 4,
    Player = 5,
    EventNpc = 6,
    Behavior7 = 7,
    MobVillageNpc = 8,
    Route = 9,
    Point = 10,
    Behavior11 = 11,
    Interact = 12,
    EntityAccessor = 13,
    Treasure = 15, // or 14?
    PlayerNpc = 16, // or 15?
    SideQuestNpc = 17, // or 16?

}
