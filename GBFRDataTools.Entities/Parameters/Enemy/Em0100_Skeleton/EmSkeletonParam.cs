using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0100_Skeleton;

public class EmSkeletonParam : EnemyParameterInfo
{
    [JsonPropertyName("angleRate_")]
    public float AngleRate { get; set; }

    [JsonPropertyName("counterAttackProbability_")]
    public int CounterAttackProbability { get; set; }

    [JsonPropertyName("jumpingCatchCoolSec_")]
    [Editable(false)]
    public BindingList<float> JumpingCatchCoolSec { get; set; } = [.. Enumerable.Repeat(0, 5).ToList()]; // std::array<int,4>>

    [JsonPropertyName("jumpingCatchStartMinSec_")]
    public BindingList<float> JumpingCatchStartMinSec { get; set; } = [.. Enumerable.Repeat(0, 5).ToList()]; // std::array<float,5>>

    [JsonPropertyName("jumpingCatchStartMaxSec_")]
    public BindingList<float> JumpingCatchStartMaxSec { get; set; } = [.. Enumerable.Repeat(0, 5).ToList()]; // std::array<float,5>>

    [JsonPropertyName("assultCountMax_")]
    public int AssultCountMax { get; set; }

    [JsonPropertyName("posInterpMaxLength_")]
    public float PosInterpMaxLength { get; set; }

    [JsonPropertyName("rotInterpMaxDegree_")]
    public float RotInterpMaxDegree { get; set; }
}
