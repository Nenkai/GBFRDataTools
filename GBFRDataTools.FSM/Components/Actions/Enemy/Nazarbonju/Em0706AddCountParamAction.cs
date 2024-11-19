using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Nazarbonju;

public class Em0706AddCountParamAction : Em0500SplineAction
{
    [JsonPropertyName("setCountParamType_")]
    public int SetCountParamType { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }
}
