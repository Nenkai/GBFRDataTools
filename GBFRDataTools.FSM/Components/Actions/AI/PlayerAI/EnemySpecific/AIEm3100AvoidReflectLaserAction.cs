﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

public class AIEm3100AvoidReflectLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm3100AvoidReflectLaserAction);
}
