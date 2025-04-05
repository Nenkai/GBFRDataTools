using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallEnemyFSM : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallEnemyFSM);

    [JsonPropertyName("fsmFileName_")]
    public string FsmFileName { get; set; } = string.Empty;
}
