using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPhtProhibit : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPhtProhibit);

    [JsonPropertyName("keyType_")]
    public EnumString<SetPhtProhibitKeyType> KeyType { get; set; } // Offset 0x30

    [JsonPropertyName("onBit_")]
    public bool OnBit { get; set; } = true; // Offset 0x60
}

public enum SetPhtProhibitKeyType
{
    // スキップ画面 = 1,
    // メインメニュー = 2,
    // 編成制限メニュー = 3,
    // クエスト専用メニュー = 4,
    // ポーズメニュー = 5,
    // 便利コマンド = 6,
    SkipScreen = 1,
    MainMenu = 2,
    FormationRestrictionMenu = 3,
    QuestMenu = 4,
    PauseMenu = 5,
    ConvenientCommands = 6,
}
