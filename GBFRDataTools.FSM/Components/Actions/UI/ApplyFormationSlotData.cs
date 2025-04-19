using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ApplyFormationSlotData : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FooterType);

    [JsonPropertyName("tableName_")]
    public string TableName { get; set; } // Offset 0x30
}
