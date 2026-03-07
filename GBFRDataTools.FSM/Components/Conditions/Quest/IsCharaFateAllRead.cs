using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class IsCharaFateAllRead : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsCharaFateAllRead);

    [JsonPropertyName("charaId_")]
    public int CharaId { get; set; } = 0;
}
