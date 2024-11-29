using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gyre;

public class Em0805ShotMoveDiagonalAction : ShotMoveStraightAction
{
    [JsonPropertyName("isDiagonalLeft_")]
    public bool IsDiagonalLeft { get; set; } = false;

    [JsonPropertyName("sideVelocity_")]
    public float SideVelocity { get; set; } = 1.0f;
}
