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
    public float CheckLength { get; set; } = 15f; // Offset 0x38

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 15f; // Offset 0x3C

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x40

    public EmSensorEyeCondition()
    {
    }
}
