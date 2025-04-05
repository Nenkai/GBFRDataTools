using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class FadeInAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FadeInAction);

    [JsonPropertyName("fadeId_")]
    public int FadeId { get; set; } = -1;

    public override string ToString()
    {
        string str = $"{ComponentName}(fadeId: {FadeId})";
        return str;
    }
}
