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

public class EmFurycaneEQSAngleTestAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneEQSAngleTestAction);

    [JsonPropertyName("checkPattern_")]
    public int CheckPattern { get; set; } = 2; // Offset 0x30

    [JsonPropertyName("min_angle_")]
    public float Min_angle { get; set; } = 0f; // Offset 0x34

    [JsonPropertyName("max_angle_")]
    public float Max_angle { get; set; } = 180f; // Offset 0x38

    public EmFurycaneEQSAngleTestAction()
    {
    }
}

