using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Sound;

public class OnStartEndWwiseEvent : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnStartEndWwiseEvent);

    [JsonPropertyName("seType_")]
    public int SeType { get; set; } = 0; // Offset 0x30

    public OnStartEndWwiseEvent()
    {
    }
}