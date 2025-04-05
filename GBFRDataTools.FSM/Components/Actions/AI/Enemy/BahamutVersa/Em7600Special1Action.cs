using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600Special1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600Special1Action);

    [JsonPropertyName("isMultiMode_")]
    public bool IsMultiMode { get; set; } = false;

    [JsonPropertyName("multiEndTime_")]
    public float MultiEndTime { get; set; } = 60.0f;
}
