using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.FastTravel;

[Description("Note: hardcoded phase numbers")]
public class FacilityFastTravel : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FacilityFastTravel);

    [JsonPropertyName("fastTravelPoint_")]
    public EnumString<FastTravelPointType> FastTravelPoint { get; set; } // Offset 0x30
}

public enum FastTravelPointType
{
    // クエストカウンター = 0,
    // 鍛冶屋 = 1,
    // よろず屋シェロ = 2,
    // 教会/ザスバの鑑定屋(未開放なら船着き場) = 3,
    // 船着き場 = 4,
    QuestCounter = 0,
    Blacksmith = 1,
    GeneralStoreSiero = 2,
    ChurchZathbaOrDockIfLocked = 3,
    Dock = 4,
}