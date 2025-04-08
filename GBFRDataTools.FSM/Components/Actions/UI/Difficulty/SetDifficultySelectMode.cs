using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Difficulty;

public class SetDifficultySelectMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDifficultySelectMode);

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } // Offset 0x30

    [JsonPropertyName("assistModeType_")]
    public EnumString AssistModeType { get; set; } // Offset 0x60
}
