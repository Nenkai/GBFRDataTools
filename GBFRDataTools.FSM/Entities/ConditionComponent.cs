using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::ConditionComponent
public class ConditionComponent : BehaviorTreeComponent
{
    [JsonPropertyName("isReverseSuccess_")]
    public bool IsReverseSuccess { get; set; }

    public override string ToString()
    {
        return ComponentName;
    }
}
