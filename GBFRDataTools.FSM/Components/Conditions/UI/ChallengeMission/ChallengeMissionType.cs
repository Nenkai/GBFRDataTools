using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.ChallengeMission;

public class ChallengeMissionType : ConditionComponent
{
    public override string ComponentName => nameof(ChallengeMissionType);

    [JsonPropertyName("type_")]
    public EnumString<ChallengeMissionTypeEnum> Type { get; set; } = new();

    [JsonPropertyName("interact_")]
    public bool Interact { get; set; } = false; 
}

public enum ChallengeMissionTypeEnum
{
    Enemy = 1,
    Snipper = 2,
}
