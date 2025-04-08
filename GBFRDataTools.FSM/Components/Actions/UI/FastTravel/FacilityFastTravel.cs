using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.FastTravel;

public class FacilityFastTravel : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FacilityFastTravel);

    [JsonPropertyName("fastTravelPoint_")]
    public EnumString FastTravelPoint { get; set; } // Offset 0x30
}
