using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Party;

public class OverwritePartyKeep : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OverwritePartyKeep);

    [JsonPropertyName("type_")]
    public EnumString<OverwritePartyKeepType> Type { get; set; } // Offset 0x30
}

public enum OverwritePartyKeepType
{
    // 全て = 0,
    // 装備のみ = 1,
    All = 0,
    Equipment = 1,
}