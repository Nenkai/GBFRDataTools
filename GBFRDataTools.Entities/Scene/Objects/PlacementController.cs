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

public class PlacementController : ISceneObject
{
    [JsonPropertyName("startOn_")]
    public bool StartOn { get; set; }

    [JsonPropertyName("startGroups_")]
    public BindingList<ulong> StartGroups { get; set; } = [];

    [JsonPropertyName("autoFinish_")]
    public bool AutoFinish { get; set; }

    [JsonPropertyName("resident_")]
    public bool Resident { get; set; }

    [JsonPropertyName("reactivateAtSavePoint_")]
    public bool ReactivateAtSavePoint { get; set; }

    [JsonPropertyName("operationDetails_")]
    public /* cy::PlacementController::OperationDetails */ Controllers<OperationDetail> OperationDetails { get; set; }

    [JsonPropertyName("routines_")]
    public object[] Routines { get; set; }
}


public class OperationDetail
{
    [JsonPropertyName("action_")]
    public int Action_ { get; set; }

    [JsonPropertyName("actionBehaviorFunctionArgs_")]
    public object[] ActionBehaviorFunctionArgs { get; set; }

    [JsonPropertyName("actionBehaviorFunctionHash_")]
    public ulong ActionBehaviorFunctionHash { get; set; }

    [JsonPropertyName("actionExtend_")]
    public int ActionExtend { get; set; }

    [JsonPropertyName("actionOption_")]
    public ulong ActionOption { get; set; }

    // This one is super weird, see c00/placement.scene
    // it's either an empty string or a number
    [JsonPropertyName("actionOptionText_")]
    public object ActionOptionText { get; set; }

    [JsonPropertyName("flags_")]
    public int Flags { get; set; }

    [JsonPropertyName("operationHash_")]
    public ulong OperationHash { get; set; }

    [JsonPropertyName("operationName_")]
    public string OperationName { get; set; }

    [JsonPropertyName("prerequisiteOperationHash_")]
    public ulong PrerequisiteOperationHash { get; set; }

    [JsonPropertyName("status_")]
    public int Status { get; set; }

    [JsonPropertyName("statusBehaviorFunctionArgs_")]
    public object[] StatusBehaviorFunctionArgs { get; set; }

    [JsonPropertyName("statusBehaviorFunctionHash_")]
    public ulong StatusBehaviorFunctionHash { get; set; }

    [JsonPropertyName("statusOption_")]
    public ulong StatusOption { get; set; }

    [JsonPropertyName("statusOptionText_")]
    public string StatusOptionText { get; set; }

    [JsonPropertyName("what_")]
    public int What { get; set; }

    [JsonPropertyName("whatOption_")]
    public ulong WhatOption { get; set; }
}
