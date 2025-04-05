using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.AngraMainyu;

public class Em7500WingHandCounterBombDebrisAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500WingHandCounterBombDebrisAction);

    [JsonPropertyName("debrisMax_")]
    public int DebrisMax { get; set; } = 10;

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 1.0f;
}
