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
public class EndlessEvent : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndlessEvent);

    [JsonPropertyName("type_")]
    public EnumString<EndlessEventType> Type { get; set; } = new();

    public enum EndlessEventType
    {
        Type0 = 0, // ルーレットのリザルトを未設定状態に変更
        Type1 = 1, // ルーレットの再回転アニメーション再生
        Type2 = 2, // ルーレットの当選枠決定アニメーション再生
        Type3 = 3, // ルーレットのボーナスアニメーション再生
        Type4 = 4, // ルーレットの再回転時のアニメーションリセット
        Type5 = 5, // 難易度選択の決定アニメ再生
        Type6 = 6, // 帰還終了リクエスト
        Type7 = 7, // ボス追加フローの成功ボイス演出を再生
    }
}
