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

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class FinishEndlessModeExBossFlow : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FinishEndlessModeExBossFlow);

    [JsonPropertyName("isSuccess_")]
    public bool IsSuccess { get; set; } = true;
}
