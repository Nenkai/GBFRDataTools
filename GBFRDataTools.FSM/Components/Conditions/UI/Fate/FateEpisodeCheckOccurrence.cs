using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Fate;

public class FateEpisodeCheckOccurrence : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FateEpisodeCheckOccurrence);

    [JsonPropertyName("checkType_")]
    public EnumString CheckType { get; set; } // Offset 0x38

    [JsonPropertyName("useSelectedFateID_")]
    public bool UseSelectedFateID { get; set; } = true; // Offset 0x68

    [JsonPropertyName("fateID_")]
    public string FateID { get; set; } // Offset 0x70

}
