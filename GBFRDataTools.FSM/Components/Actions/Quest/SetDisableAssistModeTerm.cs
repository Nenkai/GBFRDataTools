using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetDisableAssistModeTerm : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDisableAssistModeTerm);

    [JsonPropertyName("isDisable_")]
    public bool IsDisable { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
