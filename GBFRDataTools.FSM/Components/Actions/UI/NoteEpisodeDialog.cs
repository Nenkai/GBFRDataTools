using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class NoteEpisodeDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NoteEpisodeDialog);

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } // Offset 0x30

    public NoteEpisodeDialog()
    {
    }
}
