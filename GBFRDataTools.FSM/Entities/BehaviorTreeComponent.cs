using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::BehaviorTreeComponent
public class BehaviorTreeComponent
{
    [Browsable(false)]
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; } // exposed as guid_

    [Browsable(false)]
    [JsonPropertyName("parentGuid_")]
    public uint ParentGuid { get; set; } = 0xFFFFFFFF; // exposed as parentGuid_

    [Browsable(false)]
    [JsonIgnore]
    public string ComponentName { get; set; }

    public override string ToString()
    {
        return ComponentName;
    }
}
