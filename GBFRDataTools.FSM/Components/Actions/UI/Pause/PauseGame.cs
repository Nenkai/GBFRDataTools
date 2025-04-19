using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseGame : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseGame);

    [JsonPropertyName("pause_")]
    public bool Pause { get; set; } = false;

    [JsonPropertyName("offFr_")]
    public int OffFr { get; set; } = 0;

    public override string GetCaption()
    {
        return $"Pause: {Pause}";
    }
}
