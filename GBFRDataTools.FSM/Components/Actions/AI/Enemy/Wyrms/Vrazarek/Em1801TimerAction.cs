using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801TimerAction : ShotTimerAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801TimerAction);

    public Em1801TimerAction()
    { 
        WaitTimeSeconds = 1f;
        IsForceSet = false;
    }
}
