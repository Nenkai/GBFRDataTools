using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.AngraMainyu;

public class Em7500WingHandCounterBombDebrisAction : ActionComponent
{
    [JsonPropertyName("debrisMax_")]
    public int DebrisMax { get; set; }

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; }
}
