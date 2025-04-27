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

public class EmFurycaneEQSRayTestAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneEQSRayTestAction);

    [JsonPropertyName("checkPattern_")]
    public int CheckPattern { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("add_range_")]
    public float Add_range { get; set; } = 0f; // Offset 0x34

    public EmFurycaneEQSRayTestAction()
    {
    }
}