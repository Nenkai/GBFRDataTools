using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.ChallengeMission;

public class ChallengeMissionState : ConditionComponent
{
    public override string ComponentName => nameof(ChallengeMissionState);

    [JsonPropertyName("state_")]
    public EnumString<ChallengeMissionStateType> State { get; set; } // Offset 0x38
}

public enum ChallengeMissionStateType
{
    BefroreAccept = 1,
    Running = 2,
    Complete = 3,
}
