using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionLineHitCondition : ConditionComponent
{
    [JsonPropertyName("startOffset_")]
    public cVec4 StartOffset { get; set; }

    [JsonPropertyName("endOffset_")]
    public cVec4 EndOffset { get; set; }

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; }

    [JsonPropertyName("hitTypeIndex_")]
    public int HitTypeIndex { get; set; }
}
