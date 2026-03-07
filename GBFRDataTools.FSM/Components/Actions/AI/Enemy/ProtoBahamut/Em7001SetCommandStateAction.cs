using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SetCommandStateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SetCommandStateAction);

    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("pattern_")]
    public int Pattern { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0; // Offset 0x38

    public Em7001SetCommandStateAction()
    {
    }
}
