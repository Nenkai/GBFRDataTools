﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0102StepSlashAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0102StepSlashAttackAction);

    [JsonPropertyName("stepDir_")]
    public int StepDir { get; set; } = 0;
}
