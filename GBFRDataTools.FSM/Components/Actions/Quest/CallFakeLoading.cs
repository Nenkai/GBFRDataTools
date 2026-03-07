using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallFakeLoading : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallFakeLoading);

    [JsonPropertyName("tipsId_")]
    public string TipsId { get; set; } = string.Empty;

    [JsonPropertyName("dispTime_")]
    public float DispTime { get; set; } = 0;
}
