using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class EmLinkAttackParam
{
    [JsonPropertyName("linkMaxValue_")]
    public float LinkMaxValue { get; set; }

    [JsonPropertyName("linkResetTime_")]
    public float LinkResetTime { get; set; }

    [JsonPropertyName("linkResetRate_")]
    public float LinkResetRate { get; set; }

    [JsonPropertyName("linkMultiBonus_")]
    public float LinkMultiBonus { get; set; }

    [JsonPropertyName("linkCoolTime_")]
    public float LinkCoolTime { get; set; }

    [JsonPropertyName("isOverrideCircleParts_")]
    public bool IsOverrideCircleParts { get; set; }

    [JsonPropertyName("linkPartsNumber_")]
    public int LinkPartsNumber { get; set; }

    [JsonPropertyName("linkOffsetPos_")]
    public /* cVec4 */ Vector4 LinkOffsetPos { get; set; }

    [JsonPropertyName("linkCirclePartsNumber_")]
    public int LinkCirclePartsNumber { get; set; }

    [JsonPropertyName("linkCircleOffsetPos_")]
    public /* cVec4 */ Vector4 LinkCircleOffsetPos { get; set; }

    [JsonPropertyName("linkAddDist_")]
    public float LinkAddDist { get; set; }

    [JsonPropertyName("linkAdjustSec_")]
    public float LinkAdjustSec { get; set; }
}
