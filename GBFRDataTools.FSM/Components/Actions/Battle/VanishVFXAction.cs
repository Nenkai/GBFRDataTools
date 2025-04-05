﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class VanishVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(VanishVFXAction);

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("isVanishAll_")]
    public bool IsVanishAll { get; set; } = false;
}