using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class StopPlayerKey : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StopPlayerKey);

    [JsonPropertyName("isStop_")]
    public bool IsStop { get; set; } = false;

    public override string GetCaption()
    {
        return $"Stop: {IsStop}";
    }
}
