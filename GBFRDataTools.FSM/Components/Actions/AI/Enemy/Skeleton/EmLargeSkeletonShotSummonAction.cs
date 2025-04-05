﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class EmLargeSkeletonShotSummonAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLargeSkeletonShotSummonAction);
}
