using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

public class OpenFateEpisodeReward : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenFateEpisodeReward);

    [JsonPropertyName("type_")]
    public EnumString<OpenFateEpisodeRewardType> Type { get; set; } // Offset 0x30
}

public enum OpenFateEpisodeRewardType
{
    // アビリティ = 0,
    // ジーンスロット拡張 = 1,
    // リミットボーナス = 2,
    // ステータスUP = 3,
    // アーカイブ取得 = 4,

    Ability = 0,
    GeenSlotExpansion = 1,
    LimitBonus = 2,
    StatusUP = 3,
    ArchiveAcquisition = 4,
}
