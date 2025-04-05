using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Weapons;

[Obsolete("Not used by the game")]
public class We0800SetStatusAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We0800SetStatusAction);

    [JsonPropertyName("enableObjHit_")]
    public bool EnableObjHit { get; set; }

    [JsonPropertyName("enableLockOn_")]
    public bool EnableLockOn { get; set; }
}