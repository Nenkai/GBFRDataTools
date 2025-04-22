using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

using MessagePack;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Enemy;

public class EmCounterManagerParam
{
    [JsonPropertyName("countMax_")]
    public int CountMax { get; set; }

    [JsonPropertyName("intervalSecondMin_")]
    public float IntervalSecondMin { get; set; }

    [JsonPropertyName("intervalSecondMax_")]
    public float IntervalSecondMax { get; set; }
}
