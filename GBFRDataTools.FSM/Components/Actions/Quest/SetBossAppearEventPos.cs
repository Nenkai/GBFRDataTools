using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetBossAppearEventPos : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBossAppearEventPos);

    [JsonPropertyName("plPointHash_")]
    public ulong PlPointHash { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
