using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500SetAllHandAIAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500SetAllHandAIAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("isUseAI_")]
    public bool IsUseAI { get; set; } = false; // Offset 0x34

    public Em7500SetAllHandAIAction()
    {
    }
}
