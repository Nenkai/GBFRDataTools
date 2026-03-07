using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

public class ViewUpdate : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewUpdate);

    [JsonPropertyName("views_")]
    public BindingList<string> Views { get; set; } = []; // Offset 0x30

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x48

    public ViewUpdate()
    {
    }
}
