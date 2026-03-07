using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

[Description("Checks the current entity's layout type, assigned by the layout file (layout2) for the current room/stage.\n" +
    "(example: ba260c entry in the layout2 file, field18 ('type')).")]
public class TypeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TypeCondition);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;
}
