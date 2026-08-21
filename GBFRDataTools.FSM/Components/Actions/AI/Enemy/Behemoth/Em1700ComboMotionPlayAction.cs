using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ComboMotionPlayAction : ComboMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ComboMotionPlayAction);

    [JsonPropertyName("movementParam0_")]
    public MovementParam MovementParam0 { get; set; } = new();

    [JsonPropertyName("movementParam1_")]
    public MovementParam MovementParam1 { get; set; } = new();

    [JsonPropertyName("movementParam2_")]
    public MovementParam MovementParam2 { get; set; } = new();

    [JsonPropertyName("movementParam3_")]
    public MovementParam MovementParam3 { get; set; } = new();

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MovementParam
    {
        [JsonPropertyName("isChangeMovement_")]
        public bool IsChangeMovement { get; set; }

        [JsonPropertyName("normalDist_")]
        public float NormalDist { get; set; }

        [JsonPropertyName("minDist_")]
        public float MinDist { get; set; }

        [JsonPropertyName("maxDist_")]
        public float MaxDist { get; set; }

        [JsonPropertyName("offsetDist_")]
        public float OffsetDist { get; set; }

        [JsonPropertyName("setTime_")]
        public float SetTime { get; set; }

        [JsonPropertyName("movementRate_")]
        public float MovementRate { get; set; }
    }
}
