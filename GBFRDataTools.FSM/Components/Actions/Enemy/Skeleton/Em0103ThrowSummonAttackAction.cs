using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class Em0103ThrowSummonAttackAction : EmLargeSkeletonThrowSummonAttackAction
{
    [JsonPropertyName("targetDistMax_")]
    public float TargetDistMax { get; set; }
}
