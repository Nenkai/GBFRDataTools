using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ViewClose : ViewOpenClose
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewClose);

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false;
}
