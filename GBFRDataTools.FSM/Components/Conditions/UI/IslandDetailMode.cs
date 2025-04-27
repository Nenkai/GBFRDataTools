using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IslandDetailMode : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IslandDetailMode);

    [JsonPropertyName("mode_")]
    public EnumString<IslandDetailModeEnum> Mode { get; set; } // Offset 0x38

    public IslandDetailMode()
    {
    }
}
