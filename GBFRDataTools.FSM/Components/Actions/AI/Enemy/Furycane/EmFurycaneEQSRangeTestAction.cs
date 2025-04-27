using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class EmFurycaneEQSRangeTestAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneEQSRangeTestAction);

    [JsonPropertyName("checkPattern_")]
    public int CheckPattern { get; set; } = 2; // Offset 0x30

    [JsonPropertyName("min_range_")]
    public float Min_range { get; set; } = 0f; // Offset 0x34

    [JsonPropertyName("max_range_")]
    public float Max_range { get; set; } = 20f; // Offset 0x38

    public EmFurycaneEQSRangeTestAction()
    {
    }
}
