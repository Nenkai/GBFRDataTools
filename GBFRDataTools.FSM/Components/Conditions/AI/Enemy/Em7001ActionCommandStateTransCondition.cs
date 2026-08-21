using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7001ActionCommandStateTransCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ActionCommandStateTransCondition);

    [JsonPropertyName("conditionInfo_")]
    public BindingList<ConditionInfo> ConditionInfo_ { get; set; } = []; 

    [JsonPropertyName("isSuccessAny_")]
    public bool IsSuccessAny { get; set; } = false; 

    [JsonPropertyName("attributeType_")]
    public int AttributeType { get; set; } = 0;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ConditionInfo
    {
        [JsonPropertyName("conditionFlag_")]
        public int ConditionFlag { get; set; } 

        [JsonPropertyName("isSuccessFlag_")]
        public bool IsSuccessFlag { get; set; } 
    }
}