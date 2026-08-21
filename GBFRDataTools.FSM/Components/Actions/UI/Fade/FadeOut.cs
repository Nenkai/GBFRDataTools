using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fade;

public class FadeOut : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FadeOut);

    [JsonPropertyName("time_")]
    public int Time { get; set; } = 0; 

    [JsonPropertyName("type_")]
    public EnumString<FadeType> Type { get; set; } = new();

    [JsonPropertyName("layerType_")]
    public EnumString<FadeLayerType> LayerType { get; set; } = new();
}

public enum FadeLayerType
{
    Front = 0,
    Back = 1,
}
