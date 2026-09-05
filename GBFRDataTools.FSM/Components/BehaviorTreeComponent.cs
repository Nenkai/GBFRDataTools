using GBFRDataTools.Entities;

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
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components;

// BT::BehaviorTreeComponent
[AutoCollapseCategories(nameof(BehaviorTreeComponent))]
public partial class BehaviorTreeComponent : BehaviorTreeComponentBase, ICySerializable
{
    [Browsable(false)]
    [Editable(false)]
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; }

    [Browsable(false)]
    [Editable(false)]
    [JsonPropertyName("parentGuid_")]
    public uint ParentGuid { get; set; } = 0xFFFFFFFF;

    [Browsable(false)]
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorTreeComponent);

    public override string ToString()
    {
        return ComponentName;
    }
}

public abstract class BehaviorTreeComponentBase : MiniReactiveObject
{
    public abstract string ComponentName { get; }

    public virtual string? GetCaption()
    {
        return string.Empty;
    }
}
