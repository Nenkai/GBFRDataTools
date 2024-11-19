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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1800DragonicTwisterMoveAction : ShotMoveStraightAction
{
    [JsonPropertyName("lenCoefficient_")]
    public float LenCoefficient { get; set; }

    [JsonPropertyName("addAngle_")]
    public float AddAngle { get; set; }

    [JsonPropertyName("minimumRadius_")]
    public float MinimumRadius { get; set; }

    [JsonPropertyName("maximumRadius_")]
    public float MaximumRadius { get; set; }

    [JsonPropertyName("finishSignTime_")]
    public float FinishSignTime { get; set; }

}
