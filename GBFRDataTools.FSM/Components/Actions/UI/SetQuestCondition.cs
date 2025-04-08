using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetQuestCondition : ActionComponent
{
    public override string ComponentName => nameof(SetQuestCondition);

    [JsonPropertyName("result_")]
    public EnumString Result { get; set; } // Offset 0x30

    public SetQuestCondition()
    {

    }
}
