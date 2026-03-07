using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmCameraAlphaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCameraAlphaAction);

    [JsonPropertyName("isIgnore_")]
    public bool IsIgnore { get; set; } = true;

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = true;

    [JsonPropertyName("applyToChildRecursively_")]
    public bool ApplyToChildRecursively { get; set; } = false;
}
