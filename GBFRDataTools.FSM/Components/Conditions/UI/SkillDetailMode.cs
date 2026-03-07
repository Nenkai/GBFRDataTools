using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class SkillDetailMode : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SkillDetailMode);

    [JsonPropertyName("type_")]
    public EnumString<SkillDetailModeType> Type { get; set; } // Offset 0x38

    public SkillDetailMode()
    {
    }
}

public enum SkillDetailModeType
{
    // 加護付与の武器 = 5
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
    WeaponsWithBlessing = 5,
}
