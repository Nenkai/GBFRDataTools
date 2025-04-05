using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class GetStoryClearBadge : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GetStoryClearBadge);

    [JsonPropertyName("badgeVariable_")]
    public int BadgeVariable { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
