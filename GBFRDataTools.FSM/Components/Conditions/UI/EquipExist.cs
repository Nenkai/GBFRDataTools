using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class EquipExist : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EquipExist);

    [JsonPropertyName("exist_")]
    public bool Exist { get; set; } = false; // Offset 0x38

    public EquipExist()
    {
    }
}
