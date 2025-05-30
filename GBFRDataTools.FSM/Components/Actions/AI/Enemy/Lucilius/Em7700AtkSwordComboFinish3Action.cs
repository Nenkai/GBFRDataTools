﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkSwordComboFinish3Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkSwordComboFinish3Action);

    [JsonPropertyName("isUseShot_")]
    public bool IsUseShot { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isUseThreeWayShot_")]
    public bool IsUseThreeWayShot { get; set; } = false; // Offset 0x71

    [JsonPropertyName("threeWayRotY_")]
    public float ThreeWayRotY { get; set; } = 90f; // Offset 0x74

    public Em7700AtkSwordComboFinish3Action()
    {
    }
}


