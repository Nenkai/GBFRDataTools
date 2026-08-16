using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonBeginAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonBeginAction);

    [JsonPropertyName("waitVfxFrameInterval_")]
    public int WaitVfxFrameInterval { get; set; } = 15;

    [JsonPropertyName("vfxPlayFrameInterval_")]
    public int VfxPlayFrameInterval { get; set; } = 30;
}
