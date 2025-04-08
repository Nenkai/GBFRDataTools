using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

public class ViewOpenClose : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewOpenClose);

    [JsonPropertyName("views_")]
    public BindingList<string> Views { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("layerOffset_")]
    public int LayerOffset { get; set; } = 1;

    [JsonPropertyName("openSkip_")]
    public bool OpenSkip { get; set; } = false;

    [JsonPropertyName("closeSkip_")]
    public bool CloseSkip { get; set; } = false;
}
