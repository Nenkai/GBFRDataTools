﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Em2200;

public class Em2200RushSlashAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2200RushSlashAttackAction);

    public Em2200RushSlashAttackAction()
    {
    }
}
