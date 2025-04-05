using GBFRDataTools.FSM.Components.Actions;

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

// BT::QuestActionComponent
public class QuestActionComponent : ActionComponent
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

    public override string ToString()
    {
        return ComponentName;
    }
}

/// <summary>
/// stage::placement::UniqueId
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class UniqueId
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; }

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; }
}