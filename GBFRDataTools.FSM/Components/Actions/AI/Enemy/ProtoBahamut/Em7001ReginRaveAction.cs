using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001ReginRaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ReginRaveAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x64

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = true; // Offset 0x68

    [JsonPropertyName("isODAbility_")]
    public bool IsODAbility { get; set; } = false; // Offset 0x69

    public Em7001ReginRaveAction()
    {
    }
}

