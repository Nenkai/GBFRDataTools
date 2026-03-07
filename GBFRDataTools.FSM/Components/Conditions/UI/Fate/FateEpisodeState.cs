using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Fate;

public class FateEpisodeState : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FateEpisodeState);

    [JsonPropertyName("type_")]
    public EnumString<FateEpisodeStateType> Type { get; set; } // Offset 0x38
}


public enum FateEpisodeStateType
{
    // 閲覧(Watch) = 0,
    // 完了(Complete) = 1,
    // クエスト未クリア = 2,
    // 前編再生状態か = 3,
    Watch = 0,
    Complete = 1,
    QuestNotCompleted = 2,
    FirstPartPlaying = 3,
}