using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

// Checks something level or number < or > 80?
public class ExistOverLevelCharaAny : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ExistOverLevelCharaAny);

    [JsonPropertyName("checkMode_")]
    public EnumString<ExistOverLevelCharaAnyMode> CheckMode { get; set; } // Offset 0x38

    public ExistOverLevelCharaAny()
    {
    }
}

public enum ExistOverLevelCharaAnyMode
{
    // キャラ強化限界突破解放 = 0
    CharacterStrengtheningLimitBreakRelease = 0,

}
