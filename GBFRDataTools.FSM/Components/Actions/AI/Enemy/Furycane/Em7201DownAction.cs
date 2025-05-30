﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201DownAction : Em7200DownAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201DownAction);

    public Em7201DownAction()
    {
        DownTime = 10f;
    }
}
