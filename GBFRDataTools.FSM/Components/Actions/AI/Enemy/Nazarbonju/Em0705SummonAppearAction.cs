using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0705SummonAppearAction : Em0701SummonAppearAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0705SummonAppearAction);

    public Em0705SummonAppearAction()
    {
    }
}