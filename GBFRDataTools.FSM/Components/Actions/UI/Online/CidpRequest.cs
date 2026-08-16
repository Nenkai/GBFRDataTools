using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CidpRequest : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CidpRequest);

    [JsonPropertyName("type_")]
    public EnumString<CidpRequestType> Type { get; set; } 

    public enum CidpRequestType
    {
        UserAuth = 0,
        QRCode = 1,
        StatusPolling = 2,
        LinkRequest = 3,
        UnlinkRequest = 4,
        OpenOfficialSite = 5,
        ForceStopRequest = 6,
        SetLastNetworkCommand = 7,
        ResetLastNetworkCommand = 8,
    }
}

