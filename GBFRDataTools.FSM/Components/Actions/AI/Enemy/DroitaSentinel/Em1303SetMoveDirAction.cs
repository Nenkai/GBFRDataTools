using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1303SetMoveDirAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1303SetMoveDirAction);

    [JsonPropertyName("moveDirDeg_")]
    public BindingList<float> MoveDirDeg { get; set; } = []; // Offset 0x30

    [JsonPropertyName("moveDistance_")]
    public float MoveDistance { get; set; } = 6f; // Offset 0x48

    [JsonPropertyName("isCheckParentDistance_")]
    public bool IsCheckParentDistance { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("parentDistanceLimit_")]
    public float ParentDistanceLimit { get; set; } = 0f; // Offset 0x50

    public Em1303SetMoveDirAction()
    {
    }
}
