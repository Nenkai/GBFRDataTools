using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

[Description("""
    Note: Uses dialog DLG_CUT_SKIP.
    """)]
public class StoryDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StoryDialog);

    [JsonPropertyName("mode_")]
    public EnumString<StoryDialogMode> Mode { get; set; } // Offset 0x30
}

public enum StoryDialogMode
{
    // ステージ演出 = 1,
    Type0 = 0,
    StageProduction = 1,
}