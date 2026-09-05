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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7520ExAttackAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520ExAttackAction);

    [JsonPropertyName("loopStartTime")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public float LoopStartTime { get; set; }

    [JsonPropertyName("stopTime_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public float StopTime { get; set; }

    [JsonPropertyName("attackMax_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public int AttackMax { get; set; }

    [JsonPropertyName("indexWait_")]
    [Obsolete("Not exposed by the executable.")]
    [Description("Not exposed by the executable.")]
    public float IndexWait { get; set; }
}
