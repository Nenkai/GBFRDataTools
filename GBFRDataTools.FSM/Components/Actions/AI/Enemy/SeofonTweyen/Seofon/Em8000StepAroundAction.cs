using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000StepAroundAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000StepAroundAction);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0;

    [JsonPropertyName("isCallBurstVfx_")]
    public bool IsCallBurstVfx { get; set; } = true;

    [JsonPropertyName("isHL_")]
    public bool IsHL { get; set; } = false;
}
