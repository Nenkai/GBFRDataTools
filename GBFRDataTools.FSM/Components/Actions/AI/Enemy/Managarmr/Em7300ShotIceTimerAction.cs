using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300ShotIceTimerAction : ShotTimerAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300ShotIceTimerAction);

    public Em7300ShotIceTimerAction()
    {
        WaitTimeSeconds = 1f;
        IsForceSet = false;
    }
}
