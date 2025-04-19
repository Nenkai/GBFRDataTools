using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ChangeQuestHeaderMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeQuestHeaderMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString<ChangeQuestHeaderModeEnum> ModeEnum { get; set; } // Offset 0x30
}

public enum ChangeQuestHeaderModeEnum
{
    // タイトル = 0
    // クエスト = 1
    // フェイトエピソード = 2
    Title = 0,
    Quest = 1,
    FateEpisode = 2,
}