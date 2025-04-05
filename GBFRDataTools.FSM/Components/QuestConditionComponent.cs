using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components;

// BT::QuestConditionComponent
public class QuestConditionComponent : ConditionComponent
{
    [Browsable(false)]
    [JsonPropertyName("category_")]
    public uint Category { get; set; }

    [Browsable(false)]
    [JsonPropertyName("subcategory_")]
    public uint Subcategory { get; set; }

    [Browsable(false)]
    [JsonPropertyName("index_")]
    public uint Index { get; set; }

    [Browsable(false)]
    [JsonPropertyName("progressIndex_")]
    public uint ProgressIndex { get; set; }

    [Browsable(false)]
    [JsonPropertyName("progressHash_")]
    public ulong ProgressHash { get; set; }

    [Browsable(false)]
    [JsonPropertyName("isNoCheckSkip_")]
    public bool IsNoCheckSkip { get; set; }

    public override string ToString()
    {
        return ComponentName;
    }
}
