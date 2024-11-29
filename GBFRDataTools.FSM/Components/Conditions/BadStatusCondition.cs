using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class BadStatusCondition : ConditionComponent
{
    [JsonPropertyName("badStatusHash_")]
    public uint BadStatusHash { get; set; } = 0;
}
