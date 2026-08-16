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
public class QuestWaitDialogRequest : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestWaitDialogRequest);

    [JsonPropertyName("isRequest_")]
    public bool IsRequest { get; set; } = false;
}
