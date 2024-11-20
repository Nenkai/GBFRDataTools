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

public class BehaviorKnockBackAction : ActionComponent
{
    [JsonPropertyName("sourcePosition_")]
    public cVec4 SourcePosition { get; set; }

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; }

    [JsonPropertyName("moveSecond_")]
    public float MoveSecond { get; set; }
}
