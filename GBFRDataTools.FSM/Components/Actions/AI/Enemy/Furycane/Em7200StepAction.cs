using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200StepAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200StepAction);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0; // Offset 0x510

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0; // Offset 0x514

    [JsonPropertyName("minStepRate_")]
    public float MinStepRate { get; set; } = 0.6f; // Offset 0x518

    [JsonPropertyName("maxStepRate_")]
    public float MaxStepRate { get; set; } = 1.5f; // Offset 0x51C

    [JsonPropertyName("bCancel_")]
    public bool BCancel { get; set; } = false; // Offset 0x520

    public Em7200StepAction()
    {
    }
}




