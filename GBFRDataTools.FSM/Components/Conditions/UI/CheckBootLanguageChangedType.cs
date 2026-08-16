using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckBootLanguageChangedType : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckBootLanguageChangedType);

    [JsonPropertyName("type_")]
    public EnumString<CheckBootLanguageChangedTypeType> Type { get; set; }

    public enum CheckBootLanguageChangedTypeType
    {
        Type0 = 0, // 変更なし = 0,
        Type1 = 1, // 初回設定画面での言語切り替え = 1,
        Type2 = 2, // セーブデータ言語と不一致で切り替え = 2,
    }
}
