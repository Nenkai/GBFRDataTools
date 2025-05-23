﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Fate;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class FooterCloseDelayTime : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FooterCloseDelayTime);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("footer_")]
    public EnumString<FooterCloseDelayTimeFooter> Footer { get; set; } // Offset 0x38
}

public enum FooterCloseDelayTimeFooter
{
    PauseFooter = 0,
    TutorialFooter = 1,
    CommandFooter = 2,
}
