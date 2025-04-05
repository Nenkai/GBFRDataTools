using PropertyModels.ComponentModel;

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

namespace GBFRDataTools.FSM.Components;

// BT::BehaviorTreeComponent
[AutoCollapseCategories(nameof(BehaviorTreeComponent))]
public class BehaviorTreeComponent : BehaviorTreeComponentBase
{
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; } // exposed as guid_

    [JsonPropertyName("parentGuid_")]
    public uint ParentGuid { get; set; } = 0xFFFFFFFF; // exposed as parentGuid_

    [Browsable(false)]
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorTreeComponent);

    public override string ToString()
    {
        return ComponentName;
    }
}

public abstract class BehaviorTreeComponentBase
{
    public abstract string ComponentName { get; }
}
