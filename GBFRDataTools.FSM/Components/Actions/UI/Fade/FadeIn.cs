using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fade;

public class FadeIn : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FadeIn);

    [JsonPropertyName("time_")]
    public int Time { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("type_")]
    public EnumString<FadeType> Type { get; set; } // Offset 0x38
}

public enum FadeType
{
    Black = 0,
    White = 1,
}