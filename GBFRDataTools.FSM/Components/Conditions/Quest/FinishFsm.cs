using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class FinishFsm : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FinishFsm);

    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; } = 0;

    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; } = 0;
}
