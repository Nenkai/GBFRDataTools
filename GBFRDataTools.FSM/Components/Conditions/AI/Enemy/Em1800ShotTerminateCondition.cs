using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1800ShotTerminateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ShotTerminateCondition);
}
