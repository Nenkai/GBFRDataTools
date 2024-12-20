﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300DoppelTailAction : ActionComponent
{
    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("toDoppel_")]
    public bool ToDoppel { get; set; } = false;

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; } = false;

    [JsonPropertyName("animMovementRateXZ_")]
    public float AnimMovementRateXZ { get; set; } = 0.5f;
}
