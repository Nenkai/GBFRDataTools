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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801MagmaExplodeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MagmaExplodeAction);

    public Em1801MagmaExplodeAction()
    {
    }
}
