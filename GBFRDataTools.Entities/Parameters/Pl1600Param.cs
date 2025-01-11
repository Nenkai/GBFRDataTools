using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1600Param : PlayerParameterInfo
{
    [JsonPropertyName("justJumpAtkRateIncrease_")]
    public float JustJumpAtkRateIncrease { get; set; }

    [JsonPropertyName("justJumpBreakRateIncrease_")]
    public float JustJumpBreakRateIncrease { get; set; }

    [JsonPropertyName("airRushSafetyTimer_")]
    public float AirRushSafetyTimer { get; set; }

    [JsonPropertyName("laserAtkPow_")]
    public float LaserAtkPow { get; set; }

    [JsonPropertyName("laserAtkBreak_")]
    public float LaserAtkBreak { get; set; }

    [JsonPropertyName("laserAtkSpRate_")]
    public float LaserAtkSpRate { get; set; }

    // dupe?
    //[JsonPropertyName("laserAtkSpRate_")]
    //public float LaserAtkSpRate { get; set; }

    [JsonPropertyName("laserHitFrame_")]
    public float LaserHitFrame { get; set; }

    [JsonPropertyName("laserHitCount_")]
    public int LaserHitCount { get; set; }

    [JsonPropertyName("rapidInputCancelFrame_")]
    public float RapidInputCancelFrame { get; set; }

    [JsonPropertyName("justInputFrameBase_")]
    public int JustInputFrameBase { get; set; }

    [JsonPropertyName("nearCounterDist_")]
    public float NearCounterDist { get; set; }

    [JsonPropertyName("airAtkCancelDist_")]
    public float AirAtkCancelDist { get; set; }

    [JsonPropertyName("arvessCrtBuffRate_")]
    public float ArvessCrtBuffRate { get; set; }

    [JsonPropertyName("preInputAcceptFrame_")]
    public int PreInputAcceptFrame { get; set; }

    [JsonPropertyName("forceFallAddSpeedRate_")]
    public float ForceFallAddSpeedRate { get; set; }

    [JsonPropertyName("arvessAmplifyDamage_")]
    public float ArvessAmplifyDamage { get; set; }
}
