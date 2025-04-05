using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300InvincibleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300InvincibleAction);

    [JsonPropertyName("isRemove_")]
    public bool IsRemove { get; set; } = true;
}
