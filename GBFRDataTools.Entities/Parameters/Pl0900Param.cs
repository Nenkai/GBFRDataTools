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

public class Pl0900Param : PlayerParameterInfo
{
    [JsonPropertyName("addBraveGageHit_LinkAttack_")]
    public float AddBraveGageHit_LinkAttack { get; set; }

    [JsonPropertyName("addBraveGageHit_XXX_")]
    public float AddBraveGageHit_XXX { get; set; }

    [JsonPropertyName("addBraveGageHit_XYY_")]
    public float AddBraveGageHit_XYY { get; set; }

    [JsonPropertyName("addBraveGageHit_XXYY_")]
    public float AddBraveGageHit_XXYY { get; set; }

    [JsonPropertyName("addBraveGageHit_XXXYY_")]
    public float AddBraveGageHit_XXXYY { get; set; }

    [JsonPropertyName("addBraveGageGuard_")]
    public float AddBraveGageGuard { get; set; }

    [JsonPropertyName("guardPointDamageCutRate_")]
    public float GuardPointDamageCutRate { get; set; }

    [JsonPropertyName("finishAtkHitArmorKeepSec_")]
    public float FinishAtkHitArmorKeepSec { get; set; }

    [JsonPropertyName("linkTimeAtkRate_")]
    public float LinkTimeAtkRate { get; set; }

    [JsonPropertyName("linkTimeDamageLimit_")]
    public float LinkTimeDamageLimit { get; set; }
}
