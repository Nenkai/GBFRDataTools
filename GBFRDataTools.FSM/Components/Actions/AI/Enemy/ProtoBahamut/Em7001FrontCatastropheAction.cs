using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001FrontCatastropheAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001FrontCatastropheAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("rollDegree_")]
    public float RollDegree { get; set; } = -4f; // Offset 0x74

    [JsonPropertyName("rollSec_")]
    public float RollSec { get; set; } = 1.5f; // Offset 0x78

    public Em7001FrontCatastropheAction()
    {
    }
}
