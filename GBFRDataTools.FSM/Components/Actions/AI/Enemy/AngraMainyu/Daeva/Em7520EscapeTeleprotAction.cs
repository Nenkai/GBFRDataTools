﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520EscapeTeleprotAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520EscapeTeleprotAction);

    public Em7520EscapeTeleprotAction()
    {
    }
}
