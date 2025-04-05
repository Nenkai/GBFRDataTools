using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1801MagmaRockSplineAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MagmaRockSplineAction);
}
