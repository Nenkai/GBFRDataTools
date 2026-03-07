using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkParadiseLostChargeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkParadiseLostChargeAction);

    [JsonPropertyName("isCheckFullChain_")]
    public bool IsCheckFullChain { get; set; } = false; // Offset 0xA0

    [JsonPropertyName("isUseGuard_")]
    public bool IsUseGuard { get; set; } = false; // Offset 0xA1

    public Em7700AtkParadiseLostChargeAction()
    {
    }
}


