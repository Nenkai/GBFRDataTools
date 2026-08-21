using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmSensorEyeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSensorEyeCondition);

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; } = 15f; 

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 15f; 

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW;
}
