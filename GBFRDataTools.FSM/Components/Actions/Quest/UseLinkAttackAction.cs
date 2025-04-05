using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UseLinkAttackAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UseLinkAttackAction);

    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; } = 0;
}
