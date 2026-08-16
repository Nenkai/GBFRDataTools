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

[GameSupport(GameVersion.EndlessRagnarok)]
public class PreparedSubBossAppearEvent : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PreparedSubBossAppearEvent);

    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; } = 0;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0f;
}
