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

public class OpenInsertTextDialog : QuestActionComponent
{
    [JsonPropertyName("dialogId_")]
    public string DialogId { get; set; } = string.Empty;

    [JsonPropertyName("insertTextId_")]
    public string InsertTextId { get; set; } = string.Empty;

    [JsonPropertyName("textId_")]
    public string TextId { get; set; } = string.Empty;

    [JsonPropertyName("checkAtClose_")]
    public bool CheckAtClose { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
