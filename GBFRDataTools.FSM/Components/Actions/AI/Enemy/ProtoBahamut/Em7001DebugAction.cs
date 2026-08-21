using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

[Description("Stripped in release builds.")]
[Obsolete("Stripped in release builds.")]
public class Em7001DebugAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001DebugAction);

    [JsonPropertyName("debugType_")]
    public int DebugType { get; set; } = 0; 
}