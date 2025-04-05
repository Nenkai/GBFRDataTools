using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ChangeParameter : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeParameter);

    [JsonPropertyName("dispOnly_")]
    public bool DispOnly { get; set; } = false;
}
