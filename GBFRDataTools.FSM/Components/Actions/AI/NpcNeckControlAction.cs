using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

[GameSupport(GameVersion.EndlessRagnarok)]
public class NpcNeckControlAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NpcNeckControlAction);

    [JsonPropertyName("targetPos_")]
    public Vector4 TargetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("enableNeckCtrl_")]
    public bool EnableNeckCtrl { get; set; } = false;

    [JsonPropertyName("watchTarget_")]
    public bool WatchTarget { get; set; } = true;
}
