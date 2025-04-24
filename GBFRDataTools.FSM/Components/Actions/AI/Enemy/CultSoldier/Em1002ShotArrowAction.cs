using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002ShotArrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002ShotArrowAction);

    public Em1002ShotArrowAction()
    {
    }
}
