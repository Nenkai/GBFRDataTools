using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components;

// BT::ConditionComponent
public class ConditionComponent : BehaviorTreeComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ConditionComponent);

    [JsonPropertyName("isReverseSuccess_")]
    [Browsable(false)]
    public bool IsReverseSuccess { get; set; }
}
