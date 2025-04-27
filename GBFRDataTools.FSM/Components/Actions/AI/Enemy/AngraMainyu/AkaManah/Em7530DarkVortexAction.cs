using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530DarkVortexAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530DarkVortexAction);

    [JsonPropertyName("chargeTime_")]
    public float ChargeTime { get; set; } = 6f; // Offset 0x64

    public Em7530DarkVortexAction()
    {
    }
}