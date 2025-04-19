using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Shop;

public class IsSellMode : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSellMode);

    [JsonPropertyName("mode_")]
    public EnumString<IsSellModeType> Mode { get; set; } // Offset 0x38

    public IsSellMode()
    {
    }
}

public enum IsSellModeType
{
    None = 0,
    Geen = 1,
    Pendulum = 2,
    Material = 3,
}
