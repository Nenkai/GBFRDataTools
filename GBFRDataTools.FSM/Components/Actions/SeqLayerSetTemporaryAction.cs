﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class SeqLayerSetTemporaryAction : ActionComponent
{
    [JsonPropertyName("seqLayerNext_")]
    public uint SeqLayerNext { get; set; } = 0;
}
