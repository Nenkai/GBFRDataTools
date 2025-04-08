using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SetLookAtAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SetLookAtAction);

    [JsonPropertyName("isLookAt_")]
    public bool IsLookAt { get; set; } = false;

    [JsonPropertyName("lookAtParts_")]
    public int LookAtParts { get; set; } = 0;

    [JsonPropertyName("isEndOff_")]
    public bool IsEndOff { get; set; } = false;

}
