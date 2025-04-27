using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class CameraInsideCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CameraInsideCheckCondition);

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 1f; // Offset 0x38

    public CameraInsideCheckCondition()
    {
    }
}