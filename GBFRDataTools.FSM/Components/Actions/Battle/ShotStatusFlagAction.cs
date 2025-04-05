using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotStatusFlagAction : ShotHitBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotStatusFlagAction);

    [JsonPropertyName("statusFlag_")]
    public int StatusFlag { get; set; } = 0;

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true;
}
