using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Resource;

public class RequestLoadCharaImage : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RequestLoadCharaImage);
}
