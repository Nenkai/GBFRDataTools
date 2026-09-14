using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

// BT::QuestActionUseFsmBase
public class QuestActionUseFsmBase : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestActionUseFsmBase);

    [Description("FSM data number to select")]
    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; }

    [Description("FSM progress hash to select")]
    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; }

    [Description($"Whether to select select multiple FSMs (use {nameof(FsmDataInfos)})")]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; }

    [Description("List of FSM infos to select")]
    [JsonPropertyName("fsmDataInfos_")]
    public Controllers<fsmDataInfo> FsmDataInfos { get; set; } = []; // BT::QuestActionUseFsmBase::fsmDataInfos

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class fsmDataInfo
    {
        [JsonPropertyName("dataNo_")]
        public int DataNo { get; set; }

        [JsonPropertyName("progressHash_")]
        public ulong ProgressHash { get; set; }
    }
}
