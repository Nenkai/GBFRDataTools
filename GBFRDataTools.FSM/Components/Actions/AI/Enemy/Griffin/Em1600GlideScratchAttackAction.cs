﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600GlideScratchAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600GlideScratchAttackAction);

    public Em1600GlideScratchAttackAction()
    {
    }
}

