using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsOnlineLeader : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsOnlineLeader);

    [JsonPropertyName("isLocalLeader_")]
    public bool IsLocalLeader { get; set; } = true; // Offset 0x38
}
