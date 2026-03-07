using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803GroundCrackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803GroundCrackAction);

    [JsonPropertyName("nearCrackDist_")]
    public float NearCrackDist { get; set; } = 0f; // Offset 0x30

    public Em1803GroundCrackAction()
    {
    }
}
