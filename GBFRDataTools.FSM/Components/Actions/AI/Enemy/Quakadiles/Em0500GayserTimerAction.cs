using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500GayserTimerAction : ShotTimerAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500GayserTimerAction);

    public Em0500GayserTimerAction()
    {
        WaitTimeSeconds = 1f;
        IsForceSet = false;
    }
}
