using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Jump;

public class JumpPhaseTown : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(JumpPhaseTown);

    [JsonPropertyName("jumpType_")]
    public EnumString JumpType { get; set; } // Offset 0x30
}
