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

public class RequestUpdateOnlineID : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RequestUpdateOnlineID);

    [JsonPropertyName("type_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public EnumString<RequestUpdateOnlineIDType> Type { get; set; }

    public enum RequestUpdateOnlineIDType
    {
        Type0 = 0,
        Type1 = 1,
        Type2 = 2,
        Type3 = 3,
    }
}
