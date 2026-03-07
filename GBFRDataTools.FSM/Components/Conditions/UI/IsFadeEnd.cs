using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.View;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsFadeEnd : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsFadeEnd);

    [JsonPropertyName("type_")]
    public EnumString<IsFadeEndType> Type { get; set; } // Offset 0x38
}

public enum IsFadeEndType
{
    // UI(フロント) = 0,
    // フェーズジャンプ = 1,
    UI_Front = 0,
    PhaseJump = 1,
}
