﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetImpossiblePhotoMode : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetImpossiblePhotoMode);

    [JsonPropertyName("on_")]
    public bool On { get; set; } = true;

    [JsonPropertyName("isContainFTE_")]
    public bool IsContainFTE { get; set; } = false;
}
