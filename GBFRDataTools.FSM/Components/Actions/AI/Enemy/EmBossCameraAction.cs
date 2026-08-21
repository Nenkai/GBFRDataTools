using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmBossCameraAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBossCameraAction);

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true; 

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = true; 

    public override string? GetCaption()
    {
        return $"Enabled: {IsEnable} (IsSetStart: {IsSetStart})";
    }
}
