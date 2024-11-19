using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Nazarbonju;

public class Em0706CallWallHitVfxAction : Em0500SplineAction
{
    [JsonPropertyName("defaultEstId_")]
    public int DefaultEstId { get; set; }

    [JsonPropertyName("stage7EstId_")]
    public int Stage7EstId { get; set; }
}
