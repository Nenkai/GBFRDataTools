using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmExitAppearAction : ActionComponent
{
    [JsonPropertyName("isAlwaysRun_")]
    public bool IsAlwaysRun { get; set; } = false;

    [JsonPropertyName("isContinueAppear_")]
    public bool IsContinueAppear { get; set; } = false;

    [JsonPropertyName("afterType_")]
    public int AfterType { get; set; } = -1;

    [JsonPropertyName("isExitAppearWhenStart_")]
    public bool IsExitAppearWhenStart { get; set; } = false;

}
