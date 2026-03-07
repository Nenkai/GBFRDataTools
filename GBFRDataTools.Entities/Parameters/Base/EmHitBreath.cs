using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmHitBreathParam // EmHitBreath::Param
{
    [JsonPropertyName("moveAxis_")]
    public Vector3 MoveAxis { get; set; }

    [JsonPropertyName("offset_")]
    public Vector3 Offset { get; set; }

    [JsonPropertyName("rot_")]
    public Vector3 Rot { get; set; }

    [JsonPropertyName("jointNumber_")]
    public int JointNumber { get; set; }

    [JsonPropertyName("intervalSecond_")]
    public float IntervalSecond { get; set; }

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; }

    [JsonPropertyName("waitSecond_")]
    public float WaitSecond { get; set; }

    [JsonPropertyName("speed_")]
    public float Speed { get; set; }

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("maxRadius_")]
    public float MaxRadius { get; set; }

    [JsonPropertyName("hitGroundCheck")]
    public bool HitGroundCheck { get; set; }

    public EmHitBreathParam()
    {
    }
}
