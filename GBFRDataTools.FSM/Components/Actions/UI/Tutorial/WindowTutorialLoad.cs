using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.UI.Shop;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class WindowTutorialLoad : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(WindowTutorialLoad);

    public WindowTutorialLoad()
    {
    }
}
