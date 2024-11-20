using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class GenerateSmallWedgeAction : ActionComponent
{
    [JsonPropertyName("transforms_")]
    public BindingList<GenerateSmallWedgeAction_Transform> Transforms { get; set; }

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; }
}

public class GenerateSmallWedgeAction_Transform // GenerateSmallWedgeAction::Transform
{
    [JsonPropertyName("position_")]
    public cVec4 Position { get; set; }

    [JsonPropertyName("rotation_")]
    public cVec4 Rotation { get; set; }

    [JsonPropertyName("safetyAreaEffectId_")]
    public int SafetyAreaEffectId { get; set; }

    [JsonPropertyName("isLookAtHoleEffect_")]
    public bool IsLookAtHoleEffect { get; set; }

}