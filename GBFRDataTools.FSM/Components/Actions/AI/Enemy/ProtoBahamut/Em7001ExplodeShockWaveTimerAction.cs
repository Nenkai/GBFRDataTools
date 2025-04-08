using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001ExplodeShockWaveTimerAction : ShotTimerAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ExplodeShockWaveTimerAction);

    public Em7001ExplodeShockWaveTimerAction()
    {
        WaitTimeSeconds = 1f;
        IsForceSet = false;
    }
}
