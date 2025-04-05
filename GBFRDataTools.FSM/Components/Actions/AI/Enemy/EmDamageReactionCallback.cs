using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageReactionCallback : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageReactionCallback);

    [JsonPropertyName("isBeginCallback_")]
    public bool IsBeginCallback { get; set; } = true;
}
