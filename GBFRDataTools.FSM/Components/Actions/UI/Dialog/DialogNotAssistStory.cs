using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class DialogNotAssistStory : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogNotAssistStory);

    [JsonPropertyName("type_")]
    public DialogNotAssistStory Type { get; set; } // Offset 0x30

    public DialogNotAssistStory()
    {
    }
}

public enum DialogNotAssistStoryType
{
    // メインストーリー難易度 = 0
    // 選択中のチャプターセレクト難易度 = 1
    MainStoryDifficulty = 0,
    SelectedChapterDifficulty = 1,
}