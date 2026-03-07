using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Item;

public class IsItemLimitOver : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsItemLimitOver);

    [JsonPropertyName("type_")]
    public EnumString<IsItemLimitOverType> Type { get; set; }
}

public enum IsItemLimitOverType
{
    Type0 = 0,
    Geen = 1,
    Pendulum = 2,
}
