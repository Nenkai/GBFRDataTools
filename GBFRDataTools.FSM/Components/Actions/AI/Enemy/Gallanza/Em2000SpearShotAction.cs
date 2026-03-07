using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000SpearShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000SpearShotAction);

    public Em2000SpearShotAction()
    {
    }
}
