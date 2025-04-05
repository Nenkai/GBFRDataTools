using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmInvisibleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmInvisibleAction);
}
