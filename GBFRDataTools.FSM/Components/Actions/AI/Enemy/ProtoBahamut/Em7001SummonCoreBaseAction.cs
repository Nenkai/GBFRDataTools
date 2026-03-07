using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SummonCoreBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SummonCoreBaseAction);

    [JsonPropertyName("attributeType_")]
    public int AttributeType { get; set; } = 1; // Offset 0x60

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x68

    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0; // Offset 0x64

    public Em7001SummonCoreBaseAction()
    {
    }
}
