using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[Obsolete("Not used in the game")]
public class Em2400ShotHitReflectorCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotHitReflectorCondition);
}
