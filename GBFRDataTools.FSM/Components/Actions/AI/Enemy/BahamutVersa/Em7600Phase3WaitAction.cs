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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600Phase3WaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600Phase3WaitAction);

    public Em7600Phase3WaitAction()
    {
    }
}

