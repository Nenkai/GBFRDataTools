using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.Online;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

[Description("Seems to go hand in hand with IsSyncFlag")]
public class SetNetworkSyncFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetNetworkSyncFlag);

    [JsonPropertyName("flagType_")]
    public EnumString<IsSyncFlagType> FlagType { get; set; } // Offset 0x30

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = true; // Offset 0x60

    [JsonPropertyName("isSyncReset_")]
    public bool IsSyncReset { get; set; } = false; // Offset 0x61

    [JsonPropertyName("allReset_")]
    public bool AllReset { get; set; } = false; // Offset 0x62

    [JsonPropertyName("onlySyncReset_")]
    public bool OnlySyncReset { get; set; } = false; // Offset 0x63

    public SetNetworkSyncFlag()
    {
    }
}
