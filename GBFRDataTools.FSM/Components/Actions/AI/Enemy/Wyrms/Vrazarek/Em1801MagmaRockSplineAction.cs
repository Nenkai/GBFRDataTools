using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801MagmaRockSplineAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MagmaRockSplineAction);

    public Em1801MagmaRockSplineAction()
    {
        Time = 1f;
        Height = 10f;
        RotateDirection = false;
        EndTimer = true;
    }
}
