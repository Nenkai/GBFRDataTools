﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class SetNeedMaterialMode : ActionComponent
{
    [JsonPropertyName("shop_")]
    public EnumString Shop { get; set; } = new();

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } = new();
}
