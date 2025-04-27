using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001ClawBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ClawBeamAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x64

    public Em7001ClawBeamAction()
    {
    }
}