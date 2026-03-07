using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class GenerateSmallWedgeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GenerateSmallWedgeAction);

    [JsonPropertyName("transforms_")]
    public BindingList<Transform> Transforms { get; set; } = [];

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; } = 0.0f;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Transform // GenerateSmallWedgeAction::Transform
    {
        [JsonPropertyName("position_")]
        public /* cVec4 */ Vector4 Position { get; set; } = Vector4.UnitW;

        [JsonPropertyName("rotation_")]
        public /* cVec4 */ Vector4 Rotation { get; set; } = Vector4.UnitW;

        [JsonPropertyName("safetyAreaEffectId_")]
        public int SafetyAreaEffectId { get; set; } = 0;

        [JsonPropertyName("isLookAtHoleEffect_")]
        public bool IsLookAtHoleEffect { get; set; } = false;
    }
}

