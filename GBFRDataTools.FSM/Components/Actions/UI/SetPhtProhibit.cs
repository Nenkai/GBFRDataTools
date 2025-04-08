using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPhtProhibit : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOptionWindowType);

    [JsonPropertyName("keyType_")]
    public EnumString KeyType { get; set; } // Offset 0x30

    [JsonPropertyName("onBit_")]
    public bool OnBit { get; set; } = true; // Offset 0x60
}
