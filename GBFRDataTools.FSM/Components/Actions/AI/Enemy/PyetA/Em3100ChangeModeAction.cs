using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.PyetA;

public class Em3100ChangeModeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100ChangeModeAction);

    [JsonPropertyName("changeType_")]
    public int ChangeType { get; set; } = 0; // Offset 0x108

    public Em3100ChangeModeAction()
    {
    }
}
