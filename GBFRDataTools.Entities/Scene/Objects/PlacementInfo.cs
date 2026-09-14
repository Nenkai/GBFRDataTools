using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Converters;
using GBFRDataTools.Entities.Preset;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
    [Editable(false)]
    public BindingList<ulong> SignalField { get; set; } = [.. Enumerable.Repeat<ulong>(0, 4)]; // cy::PlacementInfo::Values

    [JsonPropertyName("points_")]
    public BindingList<Matrix4x4> Points { get; set; } = []; // std::vector<Hw::cMtx44>

    [JsonPropertyName("cameraFadeSettings_")]
    public BindingList<float> CameraFadeSettings { get; set; } = []; // std::vector<float>

    [JsonPropertyName("finishBehaviorFunctionArgs_")]
    public BehaviorFunctionArguments FinishBehaviorFunctionArgs { get; set; } // /* cy::BehaviorFunctionArguments */ 

    [JsonPropertyName("checkFinishBehaviorFunctionArgs_")]
    public BehaviorFunctionArguments CheckFinishBehaviorFunctionArgs { get; set; } // /* cy::BehaviorFunctionArguments */ 

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
