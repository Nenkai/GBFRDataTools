using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class DontRecording : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DontRecording);

    [JsonPropertyName("dontRecording_")]
    public bool DontRecording_ { get; set; } = false; 

    [JsonPropertyName("view_")]
    public string? View { get; set; } 
}