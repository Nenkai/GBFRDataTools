﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyvern;

public class Em0400MagmaFallCheckAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0400MagmaFallCheckAction);
}
