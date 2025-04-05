﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class BaMagmaWaveMoveWaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BaMagmaWaveMoveWaveAction);
}
