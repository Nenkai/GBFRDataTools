using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600TakeoffLandingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600TakeoffLandingAction);

    public Em1600TakeoffLandingAction()
    {
    }
}


