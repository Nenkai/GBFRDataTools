using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class BgBlackClose : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BgBlackClose);

    [JsonPropertyName("bgID_")]
    public string BgID { get; set; } = "BgBlack";
}
