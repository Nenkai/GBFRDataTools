using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Boot;

public class BootPhaseLanguageChange : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BootPhaseLanguageChange);

    [JsonPropertyName("languageChange_")]
    public bool LanguageChange { get; set; } = false;

    [JsonPropertyName("type_")]
    public EnumString<BootPhaseLanguageChangeType> Type { get; set; } = new();

    public enum BootPhaseLanguageChangeType
    {
        Type0 = 0, // 変更なし
        Type1 = 1, // 初回設定画面での言語切り替え
        Type2 = 2, // セーブデータ言語と不一致で切り替え
    }
}
