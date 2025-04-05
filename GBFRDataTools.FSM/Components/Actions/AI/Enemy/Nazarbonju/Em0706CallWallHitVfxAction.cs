using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Nazarbonju;

public class Em0706CallWallHitVfxAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706CallWallHitVfxAction);

    [JsonPropertyName("defaultEstId_")]
    public int DefaultEstId { get; set; } = 2430;

    [JsonPropertyName("stage7EstId_")]
    public int Stage7EstId { get; set; } = 2431;
}
