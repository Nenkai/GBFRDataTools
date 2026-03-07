using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceCameraCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceCameraCondition);

    [JsonPropertyName("condition_")]
    public int Condition { get; set; } = 0;
}
