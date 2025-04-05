﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionLineHitCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CollisionLineHitCondition);

    [JsonPropertyName("startOffset_")]
    public /* cVec4 */ Vector4 StartOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("endOffset_")]
    public /* cVec4 */ Vector4 EndOffset { get; set; } = new Vector4(0.0f, 0.0f, 1.0f, 1.0f);

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } = -1;

    [JsonPropertyName("hitTypeIndex_")]
    [Description("No more than 11.")]
    [Range(0, 11)]
    public int HitTypeIndex { get; set; } = 0;
}
