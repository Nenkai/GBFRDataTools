using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetQuestDetailMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetQuestDetailMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SetQuestDetailModeType> ModeEnum { get; set; } = new();

    public enum SetQuestDetailModeType
    {
        Type0 = 0, // 受注
        Type1 = 1, // 自分のクエスト確認
        Type2 = 2, // 他者クエスト確認
        Type3 = 3, // 受注クエスト確認
        Type4 = 4, // クエストリストから
    }
}
