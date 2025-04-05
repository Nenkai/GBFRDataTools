using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions;

public class DebugPrintAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DebugPrintAction);

    [JsonPropertyName("saveString_")]
    public /*sys::String*/ string SaveString { get; set; } = string.Empty;

    [JsonPropertyName("logType_")]
    public uint LogType { get; set; } = 1;

    [JsonPropertyName("outputTiming_")]
    public uint OutputTiming { get; set; } = 0;

    [JsonPropertyName("outputScreenPosition_")]
    public /* cVec2 */ Vector2 OutputScreenPosition { get; set; } = new Vector2();

    [JsonPropertyName("outputPlace_")]
    public uint OutputPlace { get; set; } = 0;
}
