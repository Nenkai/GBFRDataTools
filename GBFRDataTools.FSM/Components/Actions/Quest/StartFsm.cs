﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class StartFsm : QuestActionUseFsmBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(StartFsm);

    [Obsolete("Not used by the game")]
    [Browsable(false)]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; }

    [Obsolete("Not used by the game")]
    [Browsable(false)]
    [JsonPropertyName("fsmDataInfos_")]
    public object FsmDataInfos { get; set; }

    public override string GetCaption()
    {
        return $"Fsm {FsmDataNo}";
    }
}
