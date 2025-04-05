using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SubImportantItem : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SubImportantItem);

    [JsonPropertyName("selectIndexOfItemNameHashs_")]
    public int SelectIndexOfItemNameHashs { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
