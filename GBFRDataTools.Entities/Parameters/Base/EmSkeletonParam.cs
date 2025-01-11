using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmSkeletonParam : EnemyParameterInfo
{
    [JsonPropertyName("angleRate_")]
    public float AngleRate { get; set; }

    [JsonPropertyName("counterAttackProbability_")]
    public int CounterAttackProbability { get; set; }

    [JsonPropertyName("jumpingCatchCoolSec_")]
    public BindingList<float> JumpingCatchCoolSec { get; set; } = []; // std::array<float, 5>

    [JsonPropertyName("jumpingCatchStartMinSec_")]
    public BindingList<float> JumpingCatchStartMinSec { get; set; } // std::array<float, 5>

    [JsonPropertyName("jumpingCatchStartMaxSec_")]
    public BindingList<float> JumpingCatchStartMaxSec { get; set; } // std::array<float, 5>

    [JsonPropertyName("assultCountMax_")]
    public int AssultCountMax { get; set; }

    [JsonPropertyName("posInterpMaxLength_")]
    public float PosInterpMaxLength { get; set; }

    [JsonPropertyName("rotInterpMaxDegree_")]
    public float RotInterpMaxDegree { get; set; }
}
