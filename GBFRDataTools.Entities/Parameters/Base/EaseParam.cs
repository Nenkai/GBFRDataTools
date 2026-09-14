using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class EaseParam
{
    [JsonPropertyName("category_")]
    public EaseCategory Category { get; set; }

    [JsonPropertyName("calcType_")]
    public EaseCalcType CalcType { get; set; }
}