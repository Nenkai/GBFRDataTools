using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

public class FateEpisodeStoryTextPause : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FateEpisodeStoryTextPause);

    [JsonPropertyName("pause_")]
    public bool Pause { get; set; } = true; // Offset 0x30

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false; // Offset 0x31
}
