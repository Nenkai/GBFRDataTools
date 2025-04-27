using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OminousForm;

public class Em2800AppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2800AppearAction);

    public Em2800AppearAction()
    {
    }
}
