using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Note;

public class NoteEpisodeDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NoteEpisodeDialog);

    [JsonPropertyName("mode_")]
    public EnumString<NoteEpisodeDialogMode> Mode { get; set; } // Offset 0x30

    public NoteEpisodeDialog()
    {
    }
}

public enum NoteEpisodeDialogMode
{
    Confirm = 0, // TXT_NOTE_EPISODE_CONFIRM
    Skip = 1, // TXT_NOTE_EPISODE_SKIP
    PlayOrQuest = 2, // TXT_NOTE_EPISODE_PLAY
}
