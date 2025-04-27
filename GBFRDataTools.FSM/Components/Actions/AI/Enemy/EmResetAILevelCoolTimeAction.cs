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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmResetAILevelCoolTimeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmResetAILevelCoolTimeAction);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; } // Offset 0x30

    [JsonPropertyName("nextCoolTime_")]
    [Editable(false)]
    public BindingList<float> NextCoolTime { get; set; } = [..Enumerable.Repeat(0, 5)]; // Offset 0x54

    public EmResetAILevelCoolTimeAction()
    {
    }
}
