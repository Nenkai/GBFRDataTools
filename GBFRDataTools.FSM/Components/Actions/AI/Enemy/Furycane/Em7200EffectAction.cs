using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7200EffectAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200EffectAction);

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 8210;
}
