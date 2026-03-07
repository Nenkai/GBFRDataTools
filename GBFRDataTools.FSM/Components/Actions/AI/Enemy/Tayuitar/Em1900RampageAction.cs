using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900RampageAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900RampageAction);

    public Em1900RampageAction()
    {
    }
}


