using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class EmLargeSkeletonSlashShotAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLargeSkeletonSlashShotAttackAction);

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; } = 0;
}
