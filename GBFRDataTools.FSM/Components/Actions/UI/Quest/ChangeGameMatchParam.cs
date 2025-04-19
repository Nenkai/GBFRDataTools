using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class ChangeGameMatchParam : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeGameMatchParam);

    [JsonPropertyName("matchType_")]
    public EnumString<ChangeGameMatchParamMatchType> MatchType { get; set; } // Offset 0x30

    [JsonPropertyName("playStyle_")]
    public EnumString<ChangeGameMatchParamPlayStyle> PlayStyle { get; set; } // Offset 0x60

    [JsonPropertyName("powerAdjust_")]
    public EnumString<ChangeGameMatchParamPowerAdjust> PowerAdjust { get; set; } // Offset 0x90
}

public enum ChangeGameMatchParamMatchType
{
    // ランダム = 1,
    Random = 1, // TXT_MTC_G_ITEM_RANDOM
    Local = 2, // TXT_MTC_G_ITEM_LOCAL
}

public enum ChangeGameMatchParamPlayStyle
{
    // 未設定 = 5,
    FastestClear = 1, // TXT_MTC_G_ITEM_FASTEST_CLEAR
    BossOnly = 2, // TXT_MTC_G_ITEM_BOSS_ONLY
    GetTreasure = 3, // TXT_MTC_G_ITEM_GET_TREASURE
    BreakParts = 4, // TXT_MTC_G_ITEM_BREAK_PARTS
    NotSet = 5, // TXT_MTC_G_ITEM_NON_STYLE
}

public enum ChangeGameMatchParamPowerAdjust
{
    // なし = 1,
    None = 1, // TXT_PAU_OPT_TOG_OFF
    On = 2,
}

