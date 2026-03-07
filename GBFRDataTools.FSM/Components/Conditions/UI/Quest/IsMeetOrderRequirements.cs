using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Quest;

public class IsMeetOrderRequirements : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsMeetOrderRequirements);

    [JsonPropertyName("mode_")]
    public EnumString<IsMeetOrderRequirementsMode> Mode { get; set; } // Offset 0x38

    public IsMeetOrderRequirements()
    {
    }
}

public enum IsMeetOrderRequirementsMode
{
    OK = 0,
    Type1 = 1,
    NG = 2, // NotGood
    Type3 = 3,
}
