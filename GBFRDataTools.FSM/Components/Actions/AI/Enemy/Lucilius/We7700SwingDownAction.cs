using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class We7700SwingDownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7700SwingDownAction);

    [JsonPropertyName("offsetLength_")]
    public float OffsetLength { get; set; } = 4f; // Offset 0x60

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 5f; // Offset 0x64

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 1f; // Offset 0x68

    public We7700SwingDownAction()
    {
    }
}
