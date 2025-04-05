using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundBreakLvCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundBreakLvCondition);

    [JsonPropertyName("breakLv_")]
    public int BreakLv { get; set; } = 0;

    [JsonPropertyName("isCheckForceBreak_")]
    public bool IsCheckForceBreak { get; set; } = true;
}
