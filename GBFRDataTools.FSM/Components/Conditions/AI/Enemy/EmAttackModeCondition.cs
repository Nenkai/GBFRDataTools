using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmAttackModeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAttackModeCondition);

    [JsonPropertyName("checkMode_")]
    public AttackMode CheckMode { get; set; } = 0;

    public override string GetCaption()
    {
        return $"Mode: {CheckMode}";
    }
}

public enum AttackMode
{
    Mode0 = 0,
    Mode1 = 1,
    Mode2 = 2,
    Mode3 = 3,
}
