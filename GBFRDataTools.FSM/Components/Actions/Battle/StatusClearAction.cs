using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class StatusClearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StatusClearAction);

    [JsonPropertyName("lv_")]
    public int Lv { get; set; } = 0;

    public override string? GetCaption()
    {
        return $"Level: {Lv}";
    }
}
