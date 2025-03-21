﻿using PropertyModels.ComponentModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::BehaviorTreeComponent
[AutoCollapseCategories(nameof(BehaviorTreeComponent))]
public class BehaviorTreeComponent
{
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; } // exposed as guid_

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
