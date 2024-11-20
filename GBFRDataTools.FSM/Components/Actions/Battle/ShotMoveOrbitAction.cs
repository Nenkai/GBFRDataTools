using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class ShotMoveOrbitAction : ShotMoveBaseAction
{
    [JsonPropertyName("centerOffset_")]
    public cVec4 CenterOffset { get; set; }

    [JsonPropertyName("centerPartsNo_")]
    public int CenterPartsNo { get; set; }

    [JsonPropertyName("radiusMax_")]
    public float RadiusMax { get; set; }

    [JsonPropertyName("radiusSecondMax_")]
    public float RadiusSecondMax { get; set; }

    [JsonPropertyName("isReverseRot_")]
    public bool IsReverseRot { get; set; }
}