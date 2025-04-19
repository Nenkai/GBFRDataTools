using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetIslandDetailMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetIslandDetailMode);

    [JsonPropertyName("detailMode_")]
    public EnumString<SetIslandDetailModeEnum> DetailMode { get; set; } // Offset 0x30

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0x60

    public SetIslandDetailMode()
    {
    }
}

public enum SetIslandDetailModeEnum
{
    // 無し = 0,
    // 島選択 = 1,
    // グレード選択 = 2,
    // アイテム選択 = 3,
    // クエスト・リクエスト = 4,
    // ワールドマップ移動演出 = 5,
    // アイテム検索（島） = 6,
    // アイテム検索（グレード） = 7,
    // カテゴリ選択 = 8,
    // アイテム検索（カテゴリ） = 9,
    None = 0,
    IslandSelection = 1,
    GradeSelection = 2,
    ItemSelection = 3,
    Quest_Request = 4,
    WorldMapMovementPerformance = 5,
    ItemSearch_Island = 6,
    ItemSearch_Grade = 7,
    CategorySelection = 8,
    ItemSearch_Category = 9,
}

