using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1000Param : PlayerParameterInfo
{
    [JsonPropertyName("chargeSpeedRate_1Combo_")]
    public float ChargeSpeedRate_1Combo { get; set; }

    [JsonPropertyName("chargeSpeedRate_2Combo_")]
    public float ChargeSpeedRate_2Combo { get; set; }

    [JsonPropertyName("chargeSpeedRate_3Combo_")]
    public float ChargeSpeedRate_3Combo { get; set; }

    [JsonPropertyName("chargeSpeedRate_4Combo_")]
    public float ChargeSpeedRate_4Combo { get; set; }

    [JsonPropertyName("cyclon_RotY_")]
    public float Cyclon_RotY { get; set; }

    [JsonPropertyName("cyclon_SetDist_")]
    public float Cyclon_SetDist { get; set; }
}
