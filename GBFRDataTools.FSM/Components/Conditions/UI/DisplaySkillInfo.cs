using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class DisplaySkillInfo : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DisplaySkillInfo);

    [JsonPropertyName("page_")]
    public EnumString<DisplaySkillInfoType> Page { get; set; } = new();

    public enum DisplaySkillInfoType
    {
        Type0 = 0, // キャラ詳細
        Type1 = 1, // スキル詳細
        Type2 = 2, // マスタースキル詳細
        Type3 = 3, // スキル詳細(差分表示)
    }
}
