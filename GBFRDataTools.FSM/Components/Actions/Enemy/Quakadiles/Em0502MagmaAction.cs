using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

public class Em0502MagmaAction : Em0500SplineAction
{
    [JsonPropertyName("state_")]
    public int State { get; set; } = 0;
}
