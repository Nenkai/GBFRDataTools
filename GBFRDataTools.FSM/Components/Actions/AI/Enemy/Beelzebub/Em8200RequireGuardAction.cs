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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200RequireGuardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200RequireGuardAction);

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("isMultiWay_")]
    public bool IsMultiWay { get; set; } = false;

    [JsonPropertyName("blendMotionRateSpeed_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public float BlendMotionRateSpeed { get; set; }

    [JsonPropertyName("loopSec_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public float LoopSec { get; set; }

    [JsonPropertyName("motionInterFrame_")]
    [Description("Not exposed by the executable.")]
    [Obsolete("Not exposed by the executable.")]
    public int MotionInterFrame { get; set; }
}

