using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BehaviorHasMotionDataCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorHasMotionDataCondition);

    [JsonPropertyName("motionName_")]
    public string MotionName { get; set; }
}
