using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetNotEntertain : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetNotEntertain);

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
