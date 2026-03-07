using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700CheckTiredAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700CheckTiredAction);

    public Em1700CheckTiredAction()
    {
    }
}
