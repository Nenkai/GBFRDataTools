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

public class GetCharaTicket : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GetCharaTicket);

    [JsonPropertyName("isNotOpenDialog_")]
    public bool IsNotOpenDialog { get; set; } = false;

    [JsonPropertyName("ticketIndex_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public int TicketIndex { get; set; } = 0;
}
