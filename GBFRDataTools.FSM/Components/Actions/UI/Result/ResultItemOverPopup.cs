using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

[Description("Uses dialog id DLG_RES_MAXOVER_CODE (84E17E1E) or 0x253E4303 or 0xA4650D1B or 0x467A7C9E")]
public class ResultItemOverPopup : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultItemOverPopup);

    public ResultItemOverPopup()
    {
    }
}

