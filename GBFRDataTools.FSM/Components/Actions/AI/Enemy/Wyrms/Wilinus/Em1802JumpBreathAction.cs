using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802JumpBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802JumpBreathAction);

    public Em1802JumpBreathAction()
    {
    }
}
