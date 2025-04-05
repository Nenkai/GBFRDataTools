using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmSetEnableAttackSequenceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSetEnableAttackSequenceAction);

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = false;
}
