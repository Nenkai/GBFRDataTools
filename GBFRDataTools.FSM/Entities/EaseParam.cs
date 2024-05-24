using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::EaseParam
public class EaseParam
{
    [JsonPropertyName("category_")]
    public int Guid { get; set; }

    [JsonPropertyName("calcType_")]
    public int CalcType { get; set; }
}
