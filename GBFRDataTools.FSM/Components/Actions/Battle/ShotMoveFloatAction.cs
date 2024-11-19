
using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class ShotMoveFloatAction : ShotMoveBaseAction
{
    [JsonPropertyName("riseHeightMax_")]
    public float RiseHeightMax { get; set; }

    [JsonPropertyName("strokeHeight_")]
    public float StrokeHeight { get; set; }

    [JsonPropertyName("isRotateMoveDir_")]
    public bool IsRotateMoveDir { get; set; }
}