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
public class SetBossDeadEventPos : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBossDeadEventPos);

    [JsonPropertyName("bossPointHash_")]
    public ulong BossPointHash { get; set; }
}
