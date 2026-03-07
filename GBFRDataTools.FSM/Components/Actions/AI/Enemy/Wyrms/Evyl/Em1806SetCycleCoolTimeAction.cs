using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806SetCycleCoolTimeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806SetCycleCoolTimeAction);

    public Em1806SetCycleCoolTimeAction()
    {
    }
}