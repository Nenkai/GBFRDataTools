using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class OpenCharDialog : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenCharDialog);

    [JsonPropertyName("dialogId_")]
    public string DialogId { get; set; } // Offset 0x48

    [JsonPropertyName("textId_")]
    public string TextId { get; set; } // Offset 0x90

    [JsonPropertyName("charId_")]
    public OpenCharDialog CharId { get; set; } // Offset 0xD8

    [JsonPropertyName("checkAtClose_")]
    public bool CheckAtClose { get; set; } = false; // Offset 0x108

    public OpenCharDialog()
    {
    }
}
