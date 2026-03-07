using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class We3100DamageReactionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We3100DamageReactionCondition);

    public We3100DamageReactionCondition()
    {
    }
}