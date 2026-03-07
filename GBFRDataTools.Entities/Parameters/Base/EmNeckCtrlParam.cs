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
public class EmNeckCtrlParam
{
    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; }

    [JsonPropertyName("rootPartsNumber_")]
    public int RootPartsNumber { get; set; }

    [JsonPropertyName("basePartsNumber_")]
    public int BasePartsNumber { get; set; }

    [JsonPropertyName("baseAxisZ_")]
    public /* cVec4 */ Vector4 BaseAxisZ { get; set; }

    [JsonPropertyName("neckAxisZ_")]
    public /* cVec4 */ Vector4 NeckAxisZ { get; set; }

    [JsonPropertyName("baseDegree_")]
    public /* cVec4 */ Vector4 BaseDegree { get; set; }

    [JsonPropertyName("maxDegreeX_")]
    public float MaxDegreeX { get; set; }

    [JsonPropertyName("maxDegreeY_")]
    public float MaxDegreeY { get; set; }

    [JsonPropertyName("minDegreeX_")]
    public float MinDegreeX { get; set; }

    [JsonPropertyName("minDegreeY_")]
    public float MinDegreeY { get; set; }

    [JsonPropertyName("rotAdjustRate_")]
    public float RotAdjustRate { get; set; }

    [JsonPropertyName("rotAdjustDegreeMax_")]
    public float RotAdjustDegreeMax { get; set; }

    [JsonPropertyName("baseAxisZUpLimitDegree_")]
    public float BaseAxisZUpLimitDegree { get; set; }

    [JsonPropertyName("seqWorkIndex_")]
    public int SeqWorkIndex { get; set; }

    [JsonPropertyName("seqFlagNumber_")]
    public int SeqFlagNumber { get; set; }

    [JsonPropertyName("isSeqNeckCtrlEnable_")]
    public bool IsSeqNeckCtrlEnable { get; set; }

    [JsonPropertyName("isUseBaseParts_")]
    public bool IsUseBaseParts { get; set; }
}
