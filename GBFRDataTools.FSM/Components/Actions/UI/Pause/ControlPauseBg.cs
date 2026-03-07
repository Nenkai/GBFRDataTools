using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class ControlPauseBg : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlPauseBg);

    [JsonPropertyName("type_")]
    public EnumString<ControlPauseBgType> Type { get; set; } = new();
}

public enum ControlPauseBgType
{
    // 背景表示 = 1,
    // 背景非表示 = 2,
    // トライアル用背景表示 = 3,
    // トライアル用背景非表示 = 4,
    BackgroundDisplay = 1,
    BackgroundHidden = 2,
    TrialBackgroundDisplay = 3,
    TrialBackgroundHidden = 4,
}