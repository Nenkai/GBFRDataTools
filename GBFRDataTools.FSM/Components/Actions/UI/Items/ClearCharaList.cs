﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

namespace GBFRDataTools.FSM.Components.Actions.UI.Items;

public class ClearCharaList : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearCharaList);
}
