using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class NetworkNotice : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NetworkNotice);

    [JsonPropertyName("checkType_")]
    public EnumString CheckType { get; set; } // Offset 0x38

    public NetworkNotice()
    {
    }
}
