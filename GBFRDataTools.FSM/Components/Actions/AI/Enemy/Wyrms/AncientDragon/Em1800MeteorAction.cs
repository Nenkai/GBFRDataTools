﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800MeteorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800MeteorAction);

    public Em1800MeteorAction()
    {
    }
}
