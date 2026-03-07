using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class We1007ArrowRainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1007ArrowRainAction);

    [JsonPropertyName("signWaitTime_")]
    public float SignWaitTime { get; set; } = 0.3f; // Offset 0x84

    public We1007ArrowRainAction()
    {
    }
}