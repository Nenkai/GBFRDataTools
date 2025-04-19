using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class SetMatchingWarningFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetMatchingWarningFlag);

    [JsonPropertyName("set_")]
    public bool Set { get; set; } = false; // Offset 0x30

    public SetMatchingWarningFlag()
    {
    }
}