using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class We1100BoormerangBackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1100BoormerangBackAction);

    [JsonPropertyName("chanceSec_")]
    public float ChanceSec { get; set; } = 1.5f; // Offset 0x40

    public We1100BoormerangBackAction()
    {
    }
}
