using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SuperReginRaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SuperReginRaveAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = true; // Offset 0x74

    [JsonPropertyName("isODAbility_")]
    public bool IsODAbility { get; set; } = false; // Offset 0x75

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x78

    [JsonPropertyName("loopMotionId_")]
    public string LoopMotionId { get; set; } // Offset 0x98

    [JsonPropertyName("endMotionId_")]
    public string EndMotionId { get; set; } // Offset 0xB8

    public Em7001SuperReginRaveAction()
    {
    }
}
