using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Pause;

public class IsNeedPause : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsNeedPause);

    [JsonPropertyName("type_")]
    public EnumString<IsNeedPauseType> Type { get; set; } // Offset 0x38
}

public enum IsNeedPauseType
{
    // フェイトストーリー = 0,
    // ステージ演出スキップ = 1,
    FateStory = 0,
    SkipStageProduction = 1,
}