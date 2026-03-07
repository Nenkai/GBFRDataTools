using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Fade;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsFadingAny : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsFadingAny);

    [JsonPropertyName("isFadeTypeCheck_")]
    public bool IsFadeTypeCheck { get; set; } = false; // Offset 0x38

    [JsonPropertyName("fadeType_")]
    public EnumString<FadeType> FadeType { get; set; } // Offset 0x40

    public IsFadingAny()
    {
    }
}
