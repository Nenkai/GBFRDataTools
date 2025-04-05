using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300ShotIceTimerAction : ShotTimerAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300ShotIceTimerAction);
}
