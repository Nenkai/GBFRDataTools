using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900RushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900RushAction);

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 30f;

    [JsonPropertyName("isG3SpeedDash_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public bool IsG3SpeedDash { get; set; }

    [JsonPropertyName("g3DashMinDist_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public float G3DashMinDist { get; set; }

    [JsonPropertyName("g3DashSpeed_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public float G3DashSpeed { get; set; }

    [JsonPropertyName("g3DashAdjustDist_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public float G3DashAdjustDist { get; set; }
}