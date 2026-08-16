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

namespace GBFRDataTools.FSM.Components.Actions.Quest.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class UseSummonAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UseSummonAction);

    [JsonPropertyName("summonId_")]
    public int SummonId { get; set; } = 0;
}
