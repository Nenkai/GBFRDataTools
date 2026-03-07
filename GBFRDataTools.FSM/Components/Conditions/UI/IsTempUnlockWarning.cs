using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsTempUnlockWarning : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsTempUnlockWarning);

    [JsonPropertyName("type_")]
    public EnumString<TempUnlockWarningType> Type { get; set; } // Offset 0x38

    public IsTempUnlockWarning()
    {
    }
}
