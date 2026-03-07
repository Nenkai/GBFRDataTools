using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Shop;

public class IsSellReaffirmation : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSellReaffirmation);

    [JsonPropertyName("type_")]
    public EnumString<IsSellReaffirmationType> Type { get; set; } // Offset 0x38

    public IsSellReaffirmation()
    {
    }
}

public enum IsSellReaffirmationType
{
    None = 0,
    Reaffirmation = 1,
    ReaffirmationDLC = 2,
}
