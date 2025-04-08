using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SetManagedShotStateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SetManagedShotStateAction);

    [JsonPropertyName("isUse_")]
    public bool IsUse { get; set; } = false;
}
