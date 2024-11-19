using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AlphaAction : ActionComponent
{
    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; }

    [JsonPropertyName("alphaStart_")]
    public float AlphaStart { get; set; }

    [JsonPropertyName("alphaEnd_")]
    public float AlphaEnd { get; set; }

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; }

    [JsonPropertyName("applyToChildRecursively_")]
    public bool ApplyToChildRecursively { get; set; }
}

public class EaseParam
{
    [JsonPropertyName("category_")]
    public int Category { get; set; }

    [JsonPropertyName("calcType_")]
    public int CalcType { get; set; }
}