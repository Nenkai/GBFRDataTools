using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.FastTravel;

public class FacilityFastTravelOpenDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FacilityFastTravelOpenDialog);

    [JsonPropertyName("errorPopupID_")]
    public string ErrorPopupID { get; set; } // Offset 0x30
}
