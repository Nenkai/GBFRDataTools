using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CharaFlyParam
{
    [JsonPropertyName("speedMax_")]
    public float SpeedMax { get; set; }

    [JsonPropertyName("speedMin_")]
    public float SpeedMin { get; set; }

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; }

    [JsonPropertyName("deceleration_")]
    public float Deceleration { get; set; }

    [JsonPropertyName("backAccelScale_")]
    public float BackAccelScale { get; set; }

    [JsonPropertyName("moveAngleDiff_")]
    public float MoveAngleDiff { get; set; }

    public CharaFlyParam()
    {
    }
}
