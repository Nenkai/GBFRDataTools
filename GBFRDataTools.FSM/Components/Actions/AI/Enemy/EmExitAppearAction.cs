using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmExitAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmExitAppearAction);

    [JsonPropertyName("isAlwaysRun_")]
    public bool IsAlwaysRun { get; set; } = false;

    [JsonPropertyName("isContinueAppear_")]
    public bool IsContinueAppear { get; set; } = false;

    [JsonPropertyName("afterType_")]
    [Description("Something to do with hash 0x4B7A35FC")]
    public int AfterType { get; set; } = -1;

    [JsonPropertyName("isExitAppearWhenStart_")]
    public bool IsExitAppearWhenStart { get; set; } = false;

}
