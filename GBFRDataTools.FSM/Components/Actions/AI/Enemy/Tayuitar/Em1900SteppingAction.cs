using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900SteppingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900SteppingAction);

    [JsonPropertyName("isDouble_")]
    public bool IsDouble { get; set; } = false; // Offset 0x3C

    public Em1900SteppingAction()
    {
    }
}



