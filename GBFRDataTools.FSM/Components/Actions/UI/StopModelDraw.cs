using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class StopModelDraw : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StopModelDraw);

    [JsonPropertyName("isStop_")]
    public bool IsStop { get; set; } = false; // Offset 0x30
}
