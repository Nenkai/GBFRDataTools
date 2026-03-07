using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class StatusClearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StatusClearAction);

    [JsonPropertyName("lv_")]
    public int Lv { get; set; } = 0;
}
