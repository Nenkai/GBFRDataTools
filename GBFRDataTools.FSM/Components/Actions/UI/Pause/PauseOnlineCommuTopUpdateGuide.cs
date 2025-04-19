using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseOnlineCommuTopUpdateGuide : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseOnlineCommuTopUpdateGuide);

    public PauseOnlineCommuTopUpdateGuide()
    {
    }
}
