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
public class SummonHomingTargetEntityHandleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonHomingTargetEntityHandleAction);

    [JsonPropertyName("mode_")]
    public int Mode { get; set; } = 0;

    [JsonPropertyName("dataIndex_")]
    public int DataIndex { get; set; } = 0;
}
