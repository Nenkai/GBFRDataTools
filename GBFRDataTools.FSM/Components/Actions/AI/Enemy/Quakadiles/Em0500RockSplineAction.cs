using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500RockSplineAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500RockSplineAction);

    public Em0500RockSplineAction()
    {
        Time = 1f;
        Height = 10f;
        RotateDirection = false;
        EndTimer = true;
    }
}
