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
    public BindingList<ulong> StartGroups { get; set; }

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
    public int action_ { get; set; }
    public object[] actionBehaviorFunctionArgs_ { get; set; }
    public ulong actionBehaviorFunctionHash_ { get; set; }
    public int actionExtend_ { get; set; }
    public ulong actionOption_ { get; set; }

    // This one is super weird, see c00/placement.scene
    // it's either an empty string or a number
    public object actionOptionText_ { get; set; }
    public int flags_ { get; set; }
    public ulong operationHash_ { get; set; }
    public string operationName_ { get; set; }
    public ulong prerequisiteOperationHash_ { get; set; }
    public int status_ { get; set; }
    public object[] statusBehaviorFunctionArgs_ { get; set; }
    public ulong statusBehaviorFunctionHash_ { get; set; }
    public ulong statusOption_ { get; set; }
    public string statusOptionText_ { get; set; }
    public int what_ { get; set; }
    public ulong whatOption_ { get; set; }
}
