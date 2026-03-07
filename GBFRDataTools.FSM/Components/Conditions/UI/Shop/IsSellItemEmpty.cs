using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
namespace GBFRDataTools.FSM.Components.Conditions.UI.Shop;

public class IsSellItemEmpty : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSellItemEmpty);

    [JsonPropertyName("type_")]
    public EnumString<IsSellItemEmptyType> Type { get; set; }
}

public enum IsSellItemEmptyType
{
    Treasure = 0,
    Geen = 1,
    Pendulum = 2,
    All = 3,
}
