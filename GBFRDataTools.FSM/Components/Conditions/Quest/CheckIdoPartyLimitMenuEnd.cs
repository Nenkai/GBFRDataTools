using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckIdoPartyLimitMenuEnd : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckIdoPartyLimitMenuEnd);

    /// <summary>
    /// Will be checked against an element with key 3B581B01 ("FateEpisodeMenu"), result type of that returned and checked against this?
    /// </summary>
    [JsonPropertyName("resultType_")]
    public int ResultType { get; set; } = 1;
}
