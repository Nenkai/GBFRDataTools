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

public class SetDisableAssistModeTerm : QuestActionComponent
{
    [JsonPropertyName("isDisable_")]
    public bool IsDisable { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";

        return str;
    }
}
