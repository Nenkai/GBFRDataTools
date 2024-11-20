using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class DebugPrintAction : ActionComponent
{
    [JsonPropertyName("saveString_")]
    public /*sys::String*/ string SaveString { get; set; }

    [JsonPropertyName("logType_")]
    public uint LogType { get; set; }

    [JsonPropertyName("outputTiming_")]
    public uint OutputTiming { get; set; }

    [JsonPropertyName("outputScreenPosition_")]
    public cVec2 OutputScreenPosition { get; set; }

    [JsonPropertyName("outputPlace_")]
    public uint OutputPlace { get; set; }
}
