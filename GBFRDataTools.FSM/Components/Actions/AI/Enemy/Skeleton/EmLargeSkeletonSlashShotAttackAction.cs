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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class EmLargeSkeletonSlashShotAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLargeSkeletonSlashShotAttackAction);

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; } = 0;

    [JsonPropertyName("isStep_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsStep { get; set; } = false;
}
