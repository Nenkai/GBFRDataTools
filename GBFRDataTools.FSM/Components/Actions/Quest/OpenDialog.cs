using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class OpenDialog : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenDialog);

    [JsonPropertyName("dialogId_")]
    public string DialogId { get; set; } = string.Empty;

    [JsonPropertyName("textId_")]
    public string TextId { get; set; } = string.Empty;

    [JsonPropertyName("checkAtClose_")]
    public bool CheckAtClose { get; set; } = false;

    [JsonPropertyName("checkAtResult_")]
    [Description("Added in Endless Ragnarok.")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool CheckAtResult { get; set; } = false;

    public override string GetCaption()
    {
        return $"{DialogId}";
    }
}
