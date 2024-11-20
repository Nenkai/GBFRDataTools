using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AddRotationAction : ActionComponent
{
    [JsonPropertyName("addRotation_")]
    public cVec4 AddRotation { get; set; }

    [JsonPropertyName("totalTime_")]
    public float TotalTime { get; set; }
}