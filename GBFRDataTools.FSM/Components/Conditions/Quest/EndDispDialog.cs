using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndDispDialog : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndDispDialog);

    [JsonPropertyName("dialogId_")]
    public string DialogId { get; set; } = string.Empty;

    [JsonPropertyName("checkResult_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public int CheckResult { get; set; } = -2;
}
