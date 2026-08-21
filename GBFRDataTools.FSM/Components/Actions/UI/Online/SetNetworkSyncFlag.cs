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

public class SetNetworkSyncFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetNetworkSyncFlag);

    [JsonPropertyName("flagType_")]
    public EnumString<IsSyncFlagType> FlagType { get; set; } = new();

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = true; 

    [JsonPropertyName("isSyncReset_")]
    public bool IsSyncReset { get; set; } = false; 

    [JsonPropertyName("allReset_")]
    public bool AllReset { get; set; } = false; 

    [JsonPropertyName("onlySyncReset_")]
    public bool OnlySyncReset { get; set; } = false; 
}
