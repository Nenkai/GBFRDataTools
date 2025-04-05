﻿using GBFRDataTools.FSM.Components;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::QuestActionUseFsmBase
public class QuestActionUseFsmBase : QuestActionComponent
{
    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; }

    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; }

    public override string ToString()
    {
        return ComponentName;
    }
}
