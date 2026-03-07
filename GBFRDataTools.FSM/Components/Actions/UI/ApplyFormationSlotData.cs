using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;
using GBFRDataTools.FSM.Components.Conditions.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ApplyFormationSlotData : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ApplyFormationSlotData);

    [JsonPropertyName("tableName_")]
    public string TableName { get; set; } // Offset 0x30
}
