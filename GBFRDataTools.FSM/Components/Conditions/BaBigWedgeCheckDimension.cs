using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class BaBigWedgeCheckDimension : ConditionComponent
{
    [JsonPropertyName("dimension_")]
    public int Dimension { get; set; } = 0;
}