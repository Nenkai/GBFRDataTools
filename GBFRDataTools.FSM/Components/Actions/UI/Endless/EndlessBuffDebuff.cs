using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Endless;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EndlessBuffDebuff : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndlessBuffDebuff);

    [JsonPropertyName("type_")]
    public EnumString<EndlessBuffDebuffType> Type { get; set; } = new();

    public enum EndlessBuffDebuffType
    {
        Type1 = 1, // バフ選択回数設定
        Type2 = 2, // バフ購入ポイント消費
        Type3 = 3, // バフ引き直し時のポイント消費
        Type4 = 4, // Not used
        Type5 = 5, // Not used
        Type6 = 6, // バフ系統変化表示回数設定
        Type7 = 7, // Not used
        Type8 = 8, // Not used
        Type9 = 9, // 獲得バフIDのクリア
    }
}
