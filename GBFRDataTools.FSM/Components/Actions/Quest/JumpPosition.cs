using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class JumpPosition : QuestActionComponent
{
    [JsonPropertyName("uniqueIdHash1_")]
    public ulong UniqueIdHash1 { get; set; }

    [JsonPropertyName("uniqueIdHash2_")]
    public ulong UniqueIdHash2 { get; set; }

    [JsonPropertyName("uniqueIdHash3_")]
    public ulong UniqueIdHash3 { get; set; }

    [JsonPropertyName("uniqueIdHash4_")]
    public ulong UniqueIdHash4 { get; set; }

    [JsonPropertyName("fitToGround_")]
    public bool FitToGround { get; set; }

    [JsonPropertyName("guestNpc_")]
    public bool GuestNpc { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
