using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageMotionPlayAction : ActionComponent
{
    [JsonPropertyName("animId_")]
    public string AnimId { get; set; }

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; }

    [JsonPropertyName("animMoveRateXZ_")]
    public float AnimMoveRateXZ { get; set; }

    [JsonPropertyName("animMoveRateY_")]
    public float AnimMoveRateY { get; set; }

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; }

    [JsonPropertyName("animSpeedStep_")]
    public int AnimSpeedStep { get; set; }

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; }

    [JsonPropertyName("gravityRateStep_")]
    public int GravityRateStep { get; set; }
}
