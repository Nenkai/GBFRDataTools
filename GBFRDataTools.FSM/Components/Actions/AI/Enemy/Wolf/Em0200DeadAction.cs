﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200DeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200DeadAction);

    public Em0200DeadAction()
    {
    }
}
