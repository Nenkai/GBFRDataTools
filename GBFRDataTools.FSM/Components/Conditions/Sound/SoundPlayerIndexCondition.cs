using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerIndexCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundPlayerIndexCondition);

    [JsonPropertyName("isNpcCheck_")]
    public bool IsNpcCheck { get; set; } = false;

    [JsonPropertyName("checkPlayerIndex_")]
    public int CheckPlayerIndex { get; set; } = 0;
}
