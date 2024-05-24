using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class StopFsm : QuestActionComponent
{
    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; }

    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
