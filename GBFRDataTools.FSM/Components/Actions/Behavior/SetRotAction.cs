using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[Description("Sets entity rotation")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class SetRotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRotAction);

    [JsonPropertyName("rot_")]
    public Vector4 Rot { get; set; } = Vector4.UnitZ;

    [JsonPropertyName("setFlag_")]
    public uint SetFlag { get; set; } = 0;

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = true;
}
