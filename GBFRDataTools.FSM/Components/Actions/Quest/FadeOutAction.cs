using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class FadeOutAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FadeOutAction);

    [JsonPropertyName("fadeId_")]
    public int FadeId { get; set; } = -1;

    [JsonPropertyName("fadeTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float FadeTime { get; set; } = 0.5f;

    public override string GetCaption()
    {
        string str = $"FadeId: {FadeId}";
        return str;
    }
}
