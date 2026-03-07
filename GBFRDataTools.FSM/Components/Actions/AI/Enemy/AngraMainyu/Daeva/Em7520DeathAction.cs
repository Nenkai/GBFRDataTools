using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520DeathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520DeathAction);

    [JsonPropertyName("isBlow_")]
    public bool IsBlow { get; set; } = true; // Offset 0x44

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 0.5f; // Offset 0x40

    public Em7520DeathAction()
    {
    }
}
