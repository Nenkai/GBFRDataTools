using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CancelOverwriteBloomTalk : QuestActionComponent
{
    [JsonPropertyName("ownerUniqueId_")]
    public ulong OwnerUniqueId { get; set; } = 0;
}
